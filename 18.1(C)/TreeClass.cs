using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._1_C_
{
    /*	Дано упорядоченное дерево глубины N(> 0), каждая внутренняя вершина которого имеет K(< 9)
     *	непосредственных потомков, которые нумеруются от 1 до K.Корень дерева имеет номер 0. 
     *	Записать в текстовый файл все возможные пути, ведущие от корня к листьям (каждый путь записывается в
     *	отдельной строке файла). Перебирать пути, начиная с "самого левого" и заканчивая "самым правым",
     *	при этом первыми заменять конечные элементы пути.
    */
    public class TreeClass
    {
        

        private  Node root = new Node();

        private static Random rnd = new Random();


        public void CreateTree(int N, int K)
        {
            root = GenerateSubtree(N, K, 0);
           
        }

        private static Node GenerateSubtree(int N, int K, int i)
        {

            if (N == 0)
                return null;


            Node p = new Node();
            p.value = i;
            if (N == 1)
                return p;
            
            int count = K;
            for (int j = 0; j < count; j++)
            {
                p.children.Add(new Node());
                p.children[j] = GenerateSubtree(N - 1, K, j + 1);
            }
            return p;

        }



        public List<string> FindAllPaths()
        {
            string path = "";
            List<string> allpaths = new List<string>();
            FindPaths(root, path, allpaths);

            return allpaths;

        }

        private  static void FindPaths(Node node, string path, List<string> allpaths)
        {
            path += node.value;

            if (node.children.Count==0)
            {
                allpaths.Add(path);
                return;
             }
            
            for (int i = 0; i < node.children.Count; i++)
            {
               FindPaths(node.children[i], path, allpaths);
            }

        
        }
    }
}

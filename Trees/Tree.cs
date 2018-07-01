using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trees
{
   public class Node
        {
        public int value { get; set; }
        public List<Node> children = new List<Node>();

        }

    public class Tree
    {
        int N { get; set; }
        int K { get; set; }
        public Tree(int N, int K)
        {
            this.N = N;
            this.K = K;
        }

        private Node root;

        private static Random rnd = new Random();


        public void CreateTree()
        {
            root.value = 0;

            if (N> 1)
            {
               int count= rnd.Next(0,  K+1);
                
                for(int i=0; i<count; i++)
                {
                    root.children.Add(new Node());
                    root.children[i] = GenerateSubtree(N - 1, K, i+1);
                }
               
            }
               
        }

        private Node GenerateSubtree(int N, int K, int i)
        {
            
            if (N == 0)
                return null;

          
            Node p = new Node();
            p.value = i;
            int count = rnd.Next(0, K + 1);
            for (int j = 0; j < count; j++)
            {
                p.children.Add(new Node());
                p.children[j] = GenerateSubtree(N - 1, K, j + 1);
            }
             return p;

        }

        

        public List<string> FindAllPaths()
        {
            List<string> allpaths = new List<string>();
            FindPaths(root, "", allpaths);

            return allpaths;
          
        }

        private void FindPaths(Node node, string path, List<string> allpaths)
        {
            path += node.value; //можно с "->"

            if (node.children.Count == 0)
            {
                allpaths.Add(path);
            }

            for(int i=0; i<node.children.Count; i++)
            {
                FindPaths(node.children[i], path, allpaths);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._6_C_
{
    public class TreeNode
    {
        public int value { get; set; }
        public TreeNode left;
        public TreeNode right;

    }

    public class ClassTree
    {
        private TreeNode root = new TreeNode();

        private static Random rnd = new Random();

        public void CreateTree(int N)
        {
            root = GenerateSubtree(N);
        }

        private TreeNode GenerateSubtree(int N)
        {
            if (N == 0)
                return null;

            TreeNode p = new TreeNode();
            p.value = rnd.Next(0, 50);
            p.left = GenerateSubtree(N - 1);
            p.right = GenerateSubtree(N - 1);

            return p;

        }

       //распечатать элементы бинарного дерева (рекурсия)

        public List<string> Print()
        {
            List<string> list = new List<string>();
         
            PrintNode(root, "", list, false);

            return list;
        }



      

        private void PrintNode(TreeNode p, string otstup, List<string> list, bool left)
        {
            if (p != null)
            {
                string s = "";
                if (p != root)
                {
                    s = otstup + "|__" + p.value;

                    if (left)
                    {
                        otstup += "|  ";
                    }
                    else
                    {
                        otstup += "   ";
                    }

                }
                else
                {
                    s = Convert.ToString(p.value);
                }
                list.Add(s);

                PrintNode(p.left, otstup, list, true);

                PrintNode(p.right, otstup, list, false);

            }
        }

    }
}

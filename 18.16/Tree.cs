using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _18._16
{
    /*
     Реализовать рекурсивную процедуру печати всех элементов заданного двоичного дерева.
    */

    public class TreeNode
    {
        public int value { get; set; }
        public TreeNode left;
        public TreeNode right;

    }


    public class Tree
    {
        private static TreeNode root = new TreeNode();

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

      

        public string Print()
        {
            List<string> list = new List<string>();
            PrintNode(root, 2, list);

            return ListToString(list);
        }

        private string ListToString(List<string> list)
        {
            string s = null;
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i] + Environment.NewLine;
            }
            return s;

        }

        private void PrintNode(TreeNode p, int level, List<string> list)
        {
            if (p != null)
            {
                string s = "";
                for (int i = 0; i < level - 2; i++)
                    s+= "    ";
                for (int i = level - 2; i < level; i++)
                    s += "_";
                s += p.value;
                list.Add(s);

                PrintNode(p.left, level + 1, list);

                PrintNode(p.right, level + 1, list);

            }


        }



        public Bitmap Draw()
        {
            Bitmap bitmap = new Bitmap(900, 500);
            DrawLine(bitmap, root, 30, 480, 70);
            DrawNode(bitmap, root, 30, 480, 70);
            return bitmap;
        }
        private void DrawLine(Bitmap bitmap, TreeNode node, int x, int y, int h)
        {
            if (node == null)
            {
                return;
            }
            int m = (x + y) / 2;
            Graphics graphics = Graphics.FromImage(bitmap);
            if (node.left != null)
            {
                graphics.DrawLine(Pens.Black, m, h, (x + m) / 2, h + 40);
            }
            if (node.right != null)
            {
                graphics.DrawLine(Pens.Black, m, h, (y + m) / 2, h + 40);
            }
            DrawLine(bitmap, node.left, x, m, h + 40);
            DrawLine(bitmap, node.right, m, y, h + 40);
        }
       private void DrawNode(Bitmap bitmap, TreeNode node, int x, int y, int h)
        {
            if (node == null)
            {
                return;
            }
            int m = (x + y) / 2;
            int r = m - x > 15 ? 15 : y - x > 1 ? (y - x) / 2 : 2;
            Graphics graphics = Graphics.FromImage(bitmap);
           
            graphics.FillEllipse(Brushes.GreenYellow, m - r, h - r, r * 2, r * 2);
           
            graphics.DrawEllipse(Pens.Black, m - r, h - r, r * 2, r * 2);
            graphics.DrawString(Convert.ToString(node.value), new Font("Arial", (int)(r * 0.9)), Brushes.Black, (float)(m - r / 1.2), (float)(h - r / 1.2));
            DrawNode(bitmap, node.left, x, m, h + 40);
            DrawNode(bitmap, node.right, m, y, h + 40);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._16
{
    public partial class Tree_Form : Form
    {
        Tree tree = new Tree();
        
        public Tree_Form()
        {
            InitializeComponent();
        }

        private void Tree_Form_Load(object sender, EventArgs e)
        {

        }

       

        private void createButton_Click(object sender, EventArgs e)
        {
            tree.CreateTree(Convert.ToInt32(depthTextBox.Text));
            pictureBox1.Image = tree.Draw();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            
           string s =tree.Print();


            printTextBox.Text = s;
           


        }

        private void printTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

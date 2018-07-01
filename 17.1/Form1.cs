using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._1
{
    public partial class Interpreter_form : Form
    {
        public Interpreter_form()
        {
            InitializeComponent();
        }

        private void Result_button_Click(object sender, EventArgs e)
        {
            try
            {
                ExpressionNode expressionNode = InterpreterClass.GetExpressionTree(Expression_textBox.Text);
                Result_label.Text = expressionNode.Calculate().ToString();

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: Неверный формат строки");
            }
             

               

        }
    }
}

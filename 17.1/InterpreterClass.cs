using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1
{
    /*	Вывести значение целочисленного выражения, заданного в виде строки S.
     Выражение определяется следующим образом: 
      выражение>  ::= <число> | <выражение> + <число>  | <выражение> – <число> 
    */
    public enum ExpressionType
    {
        NUMBER, PLUS, MINUS
    };

    public class ExpressionNode
    {
        private ExpressionNode left;
        private int right;
        private ExpressionType expressionType;

        public ExpressionNode(ExpressionNode left, int right, ExpressionType expressionType)
        {
            this.left = left;
            this.right = right;
            this.expressionType = expressionType;
        }

        public int Calculate()
        {
            switch (expressionType)
            {
                case ExpressionType.NUMBER:
                    return right;

                case ExpressionType.PLUS:
                    return left.Calculate() + right;

                case ExpressionType.MINUS:
                    return left.Calculate() - right;

                default:
                    throw new Exception();
            }
        }
    }

    public  class InterpreterClass
    {
        private static string TestString(string str)
        {
            str = str.Replace(" ", "").Replace("\t", "");

            for (int i = 0; i < str.Length; i++)
                if ((str[i] < '0' || str[i] > '9') && str[i] != '+' && str[i] != '-')
                    throw new Exception();

            return str;
        }

        public static ExpressionNode GetExpressionTree(string expression)
        {
            expression = TestString(expression);

            return ProcessExpression(expression);
        }

        public static ExpressionNode ProcessExpression(string expression)
        {
            int operationPos = -1;

            for (int i = expression.Length - 1; i >= 0; i--)
                if (expression[i] == '+' || expression[i] == '-')
                {
                    operationPos = i;
                    break;
                }

            if (operationPos == -1)
            {
                return new ExpressionNode(null, int.Parse(expression), ExpressionType.NUMBER);
            }

            int right = int.Parse(expression.Substring(operationPos + 1, expression.Length - operationPos - 1));

            char operation = expression[operationPos];
            ExpressionType operationType;

            if (operation == '+')
                operationType = ExpressionType.PLUS;
            else if (operation == '-')
                operationType = ExpressionType.MINUS;
            else
                throw new Exception(); 

            ExpressionNode left = ProcessExpression(expression.Substring(0, operationPos));

            return new ExpressionNode(left, right, operationType);
        }
    }
}

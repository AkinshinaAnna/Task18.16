using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _18._6_C_
{
    class Program
    {
        public static string ReadValueFromConsole(string a)
        {

            Console.Write("Введите {0} ", a);
            string s = Console.ReadLine();

            return s;
        }

        public static bool AskQuestion(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();

                if (answer == "yes" || answer == "no")
                    return answer == "yes";
            }
        }

        public static void Print( ClassTree tree)
        {
            List<string> list = new List<string>();
            list = tree.Print();

            if (AskQuestion("Хотите вывести результат в файле? yes/no "))
            {
                string path = ReadValueFromConsole("путь к файлу");
                FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter f = new StreamWriter(file);
                for (int i = 0; i < list.Count; i++)
                {
                    f.WriteLine(list[i]);
                }
                f.Close();
                file.Close();
                return;

            }
           
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите глубину дерева N ");
                int N = Convert.ToInt32(Console.ReadLine());
               
               
                ClassTree tree = new ClassTree();
                tree.CreateTree(N);

                Print(tree);
                   
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}

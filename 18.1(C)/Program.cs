using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _18._1_C_
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

        public static void WriteToFile(string path, TreeClass tc)
        {
            List<string> allPaths = new List<string>();
            allPaths = tc.FindAllPaths();

            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter f = new StreamWriter(file);
            for(int i=0; i<allPaths.Count; i++)
            {
                f.WriteLine(allPaths[i]);
            }
            f.Close();
            file.Close();




        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите глубину дерева N ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите максимальное кол-во потомков K(<9) ");
                int K = Convert.ToInt32(Console.ReadLine());


                if (K >= 9)
                    Console.WriteLine("Максимальное кол-во потомков - 8");
                else
                {
                    TreeClass tc = new TreeClass(); 
                    tc.CreateTree(N, K);

                   string path= ReadValueFromConsole("путь к файлу: ");
                    Console.WriteLine();

                    WriteToFile(path, tc);

                    Console.WriteLine();
                    Console.WriteLine("Все возможные пути, ведущие от корня к листьям, сохранены в файл");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }

           


        }
    }
}

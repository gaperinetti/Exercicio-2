using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("nomes_telefones.txt");
            //TextReader tr = new StreamReader(@"C:\Users\...\Desktop\Test.txt"); 
            String linha = reader.ReadLine();
            while (linha != null)
            {
                int pos = linha.IndexOf('(');
                pos -= 2;

                if (pos > 11)

                    Console.WriteLine(linha.ToString().ToUpper().Replace(")", "").Replace("(", "").Replace("-", ""));
                linha = reader.ReadLine();

            }

            Console.ReadKey();
        }
    }
}

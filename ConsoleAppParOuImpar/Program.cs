using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Impar(1) ou Par(0) ");
            int escolha = int.Parse(Console.ReadLine());
            int cont = escolha;
            Console.Clear();

            while (cont <= 20)
            {
                Console.WriteLine(cont);
                cont += 2;
            }
            Console.ReadKey();
        }
    }
}

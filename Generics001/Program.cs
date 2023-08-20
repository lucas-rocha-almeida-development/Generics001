using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics001;

namespace Generics001
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PrintService<int> printService = new PrintService<int>();

            Console.Write("Quantos valores voce ira digitar : ");

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

               int x = int.Parse(Console.ReadLine());

                printService.AddValue(x);
                
            }

    
            //imprimir todos os elementos
            printService.print();
            Console.WriteLine("Primeiro valor: " + printService.First());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal peso;
            Console.Write("Informe o peso do carro em quilo: " );
            peso = decimal.Parse (Console.ReadLine());

            Console.WriteLine();

            if (peso<=1000)
            {
                Console.WriteLine("Peso adequado pode passar");
                
            }

            else
            {
                Console.WriteLine("Peso incorreto não pode passar");

            }
           
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}

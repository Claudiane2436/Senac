using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;
            string nome3;
            string nome4;
            string nome5;

            Console.Write("Coloque o primeiro nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Coloque o segundo nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Coloque o terceiro nome: ");
            nome3 = Console.ReadLine();
            Console.Write("Coloque o quarto nome: ");
            nome4 = Console.ReadLine();
            Console.Write("Coloque o quinto nome: ");
            nome5 = Console.ReadLine();
            
            Console.WriteLine("O quinto nome é: " + nome5);
            Console.WriteLine("O quarto nome é: " + nome4);
            Console.WriteLine("O terceiro nome é: " + nome3);
            Console.WriteLine("O segundo nome é: " + nome2);
            Console.WriteLine("O primeiro nome é: " + nome1);

            Console.WriteLine("Aperte qualquer tecla para fechar");
            Console.ReadKey();


        }
    }
}

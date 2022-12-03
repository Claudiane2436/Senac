using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.Write("Escolha um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escolha um segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine(resultado);
            Console.Write("Aperte qualquer tecla para fechar");
            Console.ReadLine();



        }
    }
}

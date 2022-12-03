using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal nota1, nota2, nota3, nota4, média;
            Console.Write("Escreva a primeira nota: ");
            nota1 = decimal.Parse(Console.ReadLine());
            Console.Write("Escreva a segunda nota: ");
            nota2 = decimal.Parse(Console.ReadLine());
            Console.Write("Escreva a terceira nota: ");
            nota3 = decimal.Parse(Console.ReadLine());
            Console.Write("Escreva a quarta nota: ");
            nota4 = decimal.Parse(Console.ReadLine());

            média = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A média das notas é: " + média);
            Console.WriteLine("Aperte qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal alt, peso, imc;
            Console.Write("Digite o seu peso: ");
            peso = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            alt = decimal.Parse(Console.ReadLine());

            imc = peso / (alt * alt);
            Console.WriteLine("O seu IMC é de " + imc);
            Console.WriteLine("Aperte qualquer tecla para fechar");
            Console.ReadKey();



         
        }
    }
}

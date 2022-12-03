using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, resul1,result2,result3,result4;
            Console.Write("Escolha um número: ");
            n1 = decimal.Parse(Console.ReadLine());
            Console.Write("Escolha um segundo número: ");
            n2 = decimal.Parse(Console.ReadLine());


            resul1 = n1 + n2;
            result2 = n1- n2;
            result3 = n1 * n2;
            result4 = n1 / n2;

            Console.WriteLine("A soma dos números é:" + resul1);
            Console.WriteLine("A subtração dos números é:" + result2);
            Console.WriteLine("A multiplicação dos números é: " + result3);
            Console.WriteLine("A divisão dos números é: " + result4);
            Console.Write("Aperte qualquer tecla para fechar");
            Console.ReadLine();
        }
    }
}

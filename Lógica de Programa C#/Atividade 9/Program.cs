using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal not1, not2, not3, not4, media;

            Console.Write("Por favor informe a sua primeira nota: ");
            not1 = decimal.Parse(Console.ReadLine());
            Console.Write("Por favor informe a sua segunda nota: ");
            not2 = decimal.Parse(Console.ReadLine());
            Console.Write("Por favor informe a sua terceira nota: ");
            not3 = decimal.Parse(Console.ReadLine());
            Console.Write("Por favor informe a sua quarta nota: ");
            not4 = decimal.Parse(Console.ReadLine());

            media = (not1 + not2 + not3 + not4) / 4;

            if (media >=7)
            {
                Console.WriteLine("Parabéns a sua média é de " + media + " e você foi aprovado :)");
                
            }
            else
            {
                Console.WriteLine("Estude mais a sua média é de " + media + " e foi reprovado :(");

            }
            Console.ReadKey();
        }
    }
}

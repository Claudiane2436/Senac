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
            string nome;
            int idade;

            Console.Write("Informe seu nome: ");
            nome=Console.ReadLine();
            Console.Write("Informe sua idade: ");
            idade=int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);

            Console.ReadKey();
        
        }
    }
}

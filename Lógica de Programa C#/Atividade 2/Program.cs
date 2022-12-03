using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            string cpf;
            string telefone;

            Console.Write("Informe o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe a sua idade: ");
            idade= int.Parse(Console.ReadLine());
            Console.Write ("Informe o seu cpf: ");
            cpf = Console.ReadLine();
            Console.Write("Informe o seu telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("O número do seu cpf é: " + cpf);
            Console.WriteLine("O número do seu tefelone é: " + telefone);


            Console.ReadKey();
        }
    }
}

using System;

namespace nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("ola " + nome);
        
            Console.Write(" por favor digite seu nome completo....");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("olá " + nomeCompleto);
            Console.ReadKey();
           Console.WriteLine("obrigado tenha uma boa noite");


        }
    }
}

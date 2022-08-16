using System;

namespace PrimeiraAula
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Imprime uma mensagem na tela
            Console.WriteLine("Digite um número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            //Interpolação de strings
            Console.WriteLine($"Número lido: {numero1} de novo: {numero1}");
        }
    }
}

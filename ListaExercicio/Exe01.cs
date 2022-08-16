using System;

namespace ListaExercicio
{
    class Exe01
    {
        public static void Renderizar()
        {
            //Imprimir mensagens no terminal
            Console.WriteLine("Digite a altura: ");
            //Conversão de String para um valor inteiro
            int altura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            //Conversão de String para um valor inteiro com o Convert
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = altura * largura;

            Console.WriteLine("Área: " + area);
            Console.WriteLine($"Área: { area }");
        }
    }
}
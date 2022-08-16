using System;

namespace ListaExercicio
{
    class Exe02
    {
        public static void Renderizar()
        {
            Console.WriteLine("Digite a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 13)
            {
                Console.WriteLine("Criança");
            }
            else if (idade <= 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }

        }
    }
}
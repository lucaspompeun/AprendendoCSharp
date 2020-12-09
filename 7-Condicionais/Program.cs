using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos");
            }
            else
            {
                if (quantidadePessoas >= 1)
                {
                    Console.WriteLine("Menor de 18 e acompanhado");
                }
                else
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos");
                }
            }

            Console.ReadLine();
        }
    }
}

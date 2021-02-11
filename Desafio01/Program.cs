using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Multplicando
            Console.WriteLine("Digite o mutiplicando...");
            int multiplicando = int.Parse(Console.ReadLine());

            //Input Intervalo
            Console.WriteLine("Digite o o início e o fim do intervalo a ser calculado...");
            string[] input = Console.ReadLine().Split(" ");
            int inicio = int.Parse(input[0]);
            int fim = int.Parse(input[1]);

            //Check de Erro
            if (multiplicando < 0 || multiplicando == 0 || multiplicando > 3000)
            {
                Console.WriteLine("Multiplicando Invalido! (O número deve ser positivo e menor que 3000");
            }
            if (inicio < 0 || inicio == 0 || inicio > 3000)
            {
                Console.WriteLine("Número Invalido! (O número deve ser positivo e menor que 3000");
            }
            if (fim < 0 || fim == 0 || fim > 3000)
            {
                Console.WriteLine("Número Invalido! (O número deve ser positivo e menor que 3000");
            }
            if (fim < inicio)
            {
                Console.WriteLine("Intervalo inválido");
            }
            if (fim - inicio == 10)
            {
                Console.WriteLine("O intervalo não pode ser maior que 10");
            }

            //Output
            Console.WriteLine("Multiplicando: {0}", multiplicando);
            Console.WriteLine("Início do intervalo: {0}", inicio);
            Console.WriteLine("Fim do intervalo: {0}", fim);

            for (int i = inicio; i <= fim; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", multiplicando, inicio, multiplicando * inicio);
                inicio++;
            }
        }
    }
}
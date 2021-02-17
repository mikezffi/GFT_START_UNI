using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Carga cargaTeste= new Carga();
            Caminhao caminhaoTeste = new Caminhao(cargaTeste);
            Vagao vagaoTeste = new Vagao(cargaTeste);

            Console.WriteLine("Para calcular o frete, digite o peso e o valor da carga");
            Console.Write("Peso: ");
            cargaTeste.Peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor: ");
            cargaTeste.Valor = Convert.ToDouble(Console.ReadLine());

            Decimal freteCaminhao = caminhaoTeste.CalculaFrete();
            Decimal freteVagao = vagaoTeste.CalculaFrete();

            Console.WriteLine("Valor do frete:");
            Console.WriteLine("Caminhão: " + freteCaminhao);
            Console.WriteLine("Vagão: " + freteVagao);

            Console.ReadKey();
            Console.Clear();

            SimulacaoCustoFrete simulacao = new SimulacaoCustoFrete();

            Console.ReadKey();
        }
    }
}

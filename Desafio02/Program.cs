using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Carga cargaTeste = new Carga(30000, 20000);
            Console.WriteLine("Valor do frete:");
            Console.WriteLine("Vagão: {0}", Vagao(cargaTeste).calculaFrete());
            Console.WriteLine("Caminhão: {0}", Caminhao(cargaTeste).calculaFrete());
            
        }

        public class Carga
        {
            public double Valor { get; set; }
            public double Peso { get; set; }

            public Carga(double valor, double peso)
            {
                this.Valor = valor;
                this.Peso = peso;
            }
        }

        public abstract class Transporte
        {
            public double Valor { get; set; }
            public double Peso { get; set; }
            public Transporte(Carga carga)
            {
                this.Valor = carga.Valor;
                this.Peso = carga.Peso;
            }

            public abstract double calculaFrete();
        }

        public class Vagao : Transporte
        {
            public Vagao(Carga carga)
            {
                this.Valor = carga.Valor;
                this.Peso = carga.Peso;
            }
            public override double calculaFrete()
            {
                double valor10 = Valor * 0.1;
                double peso20 = Peso * 0.2;
                double frete = valor10 + peso20;

                if (Peso < 15000)
                {
                    frete += 5000;
                }

                return frete;
            }
        }

        public class Caminhao : Transporte
        {
            public Caminhao(Carga carga)
            {
                this.Valor = carga.Valor;
                this.Peso = carga.Peso;
            }
            public override double calculaFrete()
            {
                double valor30 = Valor * 0.3;
                double peso12 = Peso * 0.12;
                double frete = valor30 + peso12;

                if (Valor > 40000)
                {
                    frete = frete * 0.75;
                }
                return frete;
            }
        }
    }
    }
}
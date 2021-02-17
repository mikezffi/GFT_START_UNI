using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    public class Carga
    {
        public Carga()
        {
            this.Peso = 0;
            this.Valor = 0;
        }
        public Carga(Double peso, Double valor)
        {
            this.Peso = peso;
            this.Valor = valor;
        }

        public Double Peso { get; set; }
        public Double Valor { get; set; }
    }
}

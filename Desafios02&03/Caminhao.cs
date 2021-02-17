using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    public class Caminhao : Transporte
    {
        public Caminhao():base()
        {
        }
        public Caminhao(Carga carga):base(carga)
        {
            this.Carga = carga;
        }

        public override decimal CalculaFrete()
        {
            Double frete;
            frete = Carga.Peso * 0.12 + Carga.Valor * 0.3;

            if (Carga.Valor > 40000)
            {
                frete *= 0.75;
            }

            return Convert.ToDecimal(frete);
        }
    }
}
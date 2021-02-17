using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    public class Vagao : Transporte
    {
        public Vagao():base()
        {
        }
        public Vagao(Carga carga):base(carga)
        {
            this.Carga = carga;
        }

        public override decimal CalculaFrete()
        {
            Double frete;
            frete = Carga.Peso * 0.2 + Carga.Valor * 0.1;

            if (Carga.Peso < 15000)
            {
                frete += 5000;
            }

            return Convert.ToDecimal(frete);
        }
    }
}

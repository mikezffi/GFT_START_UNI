using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    public class Transporte
    {
        public Transporte()
        {
        }
        public Transporte(Carga carga)
        {
            this.Carga = carga;
        }

        public Carga Carga { get; set; }

        public virtual Decimal CalculaFrete()
        {
            return 0;
        }
    }
}

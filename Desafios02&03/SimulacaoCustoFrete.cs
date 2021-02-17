using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    public class SimulacaoCustoFrete
    {
        public SimulacaoCustoFrete()
        {
            this.InitList();
            this.ComparaFrete();
        }

        private List<Carga> listaCargas;
        public List<Carga> ListaCargas
        {
            get { return listaCargas; }
        }

        private void InitList()
        {
            Carga carga;
            this.listaCargas = new List<Carga>();

            carga = new Carga(18550, 27500);
            this.listaCargas.Add(carga);
            carga = new Carga(8100, 35410);
            this.listaCargas.Add(carga);
            carga = new Carga(25700, 3650);
            this.listaCargas.Add(carga);
            carga = new Carga(9541, 5799);
            this.listaCargas.Add(carga);
            carga = new Carga(25740, 45000);
            this.listaCargas.Add(carga);
            carga = new Carga(5000, 90570);
            this.listaCargas.Add(carga);
            carga = new Carga(8900, 41000);
            this.listaCargas.Add(carga);
        }
        private void ComparaFrete()
        {
            int CaminhaoCount = 0;
            int VagaoCount = 0;
            Decimal total = 0;

            for (int i = 0; i < listaCargas.Count; i++)
            {
                Caminhao caminhao = new Caminhao(listaCargas[i]);
                Vagao vagao = new Vagao(listaCargas[i]);

                Decimal freteCaminhao = caminhao.CalculaFrete();
                Decimal freteVagao = vagao.CalculaFrete();

                if (freteCaminhao == freteVagao)
                {
                    CaminhaoCount++;
                    total = total + freteCaminhao;
                }
                if (freteCaminhao < freteVagao)
                {
                    CaminhaoCount++;
                    total = total + freteCaminhao;
                }
                if (freteCaminhao > freteVagao)
                {
                    VagaoCount++;
                    total = total + freteVagao;
                }
            }

            Console.WriteLine("Caminhões necessários: " + CaminhaoCount);
            Console.WriteLine("Vagões necessários: " + VagaoCount);
            Console.WriteLine("Total dos fretes: " + total);
        }
    }
}

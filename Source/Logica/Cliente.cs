using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbeiro_Dorminhoco.Logica
{
    class Cliente
    {
        public delegate void CortouTudoHandler();

        public event CortouTudoHandler CortouTudo;

        private int quantidadeCabelo;

        public int QuantidadeCabelo
        {
            get
            {
                return quantidadeCabelo;
            }
            set
            {
                quantidadeCabelo -= value;

                if (quantidadeCabelo <= 0)
                {
                    CortouTudo();
                }
            }
        }

        public Cliente()
        {
            quantidadeCabelo = new Random().Next(1000, 5000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Barbeiro_Dorminhoco.Logica
{
    public class Barbeiro
    {
        public delegate void FinaluzouCorteHandler();

        public event FinaluzouCorteHandler FinaluzouCorte;

        private Barbearia barbearia;
        private Timer timerTesourada;

        private void IniciarCorte(Cliente cliente)
        {
            TimerCallback tcb = new TimerCallback((o) =>
            {
                cliente.QuantidadeCabelo -= 1;

                cliente.CortouTudo += () =>
                {
                    timerTesourada.Change(Timeout.Infinite, Timeout.Infinite);
                    FinaluzouCorte();
                };
            });

            timerTesourada = new Timer(tcb, null, 10, 10);
        }
    }
}

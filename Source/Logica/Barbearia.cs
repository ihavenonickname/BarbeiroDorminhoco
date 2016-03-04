using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Barbeiro_Dorminhoco.Logica
{
    class Barbearia
    {
        private const int QUANTIDADE_MAXIMA_CLIENTES = 5;

        public delegate void IniciarAtendimentoHandler(Cliente cliente);

        public event IniciarAtendimentoHandler IniciarAtendimento;

        private Queue<Cliente> filaDeEspera = new Queue<Cliente>();
        private Timer timerFilaDeEspera;
        private Barbeiro barbeiro;

        public void iniciaAtendimentos()
        {
            TimerCallback tcb = new TimerCallback((o) =>
            {
                int qtde = new Random().Next(QUANTIDADE_MAXIMA_CLIENTES);

                if (qtde > 0)
                {
                    for (var i = 0; i < qtde || filaDeEspera.Count < QUANTIDADE_MAXIMA_CLIENTES; i++)
                        filaDeEspera.Enqueue(new Cliente());


                }
                
            });

            timerFilaDeEspera = new Timer(tcb, null, 100, 10000);
        }

        public void interrompeAtendimentos()
        {
            timerFilaDeEspera.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}

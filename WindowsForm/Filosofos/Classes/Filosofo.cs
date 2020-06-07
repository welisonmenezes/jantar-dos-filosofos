using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Filosofos.Classes
{
    class Filosofo
    {
        private string name { get; set; }
        private int index { get; set; }
        private List<Filosofo> todosFilosofos { get; set; }
        private int vezesQueComeu = 0;
        private int maximoDeVezesPraComer = 100;
        private int delay = 500;
        public Mao garfoAEsquerda { get; set; }
        public Mao garfoADireita { get; set; }
        Stopwatch cronometro;
        public Relatorio relatorio;

        public Filosofo filosofoAEsquerda
        {
            get
            {
                if (this.index == 0)
                    return this.todosFilosofos[this.todosFilosofos.Count - 1];
                else
                    return this.todosFilosofos[this.index - 1];
            }
        }

        public Filosofo filosofoADireita
        {
            get
            {
                if (this.index == this.todosFilosofos.Count - 1)
                    return this.todosFilosofos[0];
                else
                    return this.todosFilosofos[this.index + 1];
            }
        }

        public Filosofo(List<Filosofo> todosFilosofos, int index, Relatorio relatorio)
        {
            this.name = "Filosofo " + (index + 1);
            this.index = index;
            this.todosFilosofos = todosFilosofos;
            this.relatorio = relatorio;

            relatorio.adicionaRelatorio(this.name + " Comeu", 0);
            relatorio.adicionaRelatorio(this.name + " Fome", 0);
            relatorio.adicionaRelatorio(this.name + " Pensou", 0);
            relatorio.adicionaRelatorio(this.name + " Tempo", 0);
            relatorio.adicionaStatus(this.name + " Status", "");
        }

        public void ComecaAJanta()
        {

            cronometro = Stopwatch.StartNew();
            while (this.vezesQueComeu < this.maximoDeVezesPraComer)
            {
                Thread.Sleep(delay);
                this.Pensar();
                Thread.Sleep(delay);
                if (this.PegarGarfos())
                {
                    Thread.Sleep(delay);
                    this.Comer();
                    this.garfoAEsquerda.isBusy = false;
                    this.garfoADireita.isBusy = false;
                }
            }
            cronometro.Stop();

        }

        private bool PegarGarfos()
        {
            garfoADireita.isBusy = true;
            garfoAEsquerda.isBusy = true;

            if (filosofoADireita.garfoAEsquerda.isBusy)
            {
                garfoADireita.isBusy = false;
            }

            if (filosofoAEsquerda.garfoADireita.isBusy)
            {
                garfoAEsquerda.isBusy = false;
            }

            if (garfoADireita.isBusy && garfoAEsquerda.isBusy)
            {
                return true;
            }

            Console.WriteLine("O " + this.name + " está pasando fome.");
            this.relatorio.incrementaRelatorio(this.name + " Fome");
            this.relatorio.atualizaStatus(this.name + " Status", "Com Fome");

            return false;
        }

        private void Comer()
        {
            this.vezesQueComeu++;
            Console.WriteLine("O " + this.name + " está comendo.");
            this.relatorio.incrementaRelatorio(this.name + " Comeu");
            this.relatorio.atualizaStatus(this.name + " Status", "Comendo");
            if (this.vezesQueComeu == this.maximoDeVezesPraComer)
            {
                Console.WriteLine("O " + this.name + " passou " + cronometro.ElapsedMilliseconds + " milesegundos jantando.");
            }
            this.relatorio.atualizaRelatorio(this.name + " Tempo", cronometro.ElapsedMilliseconds);
           
        }

        private void Pensar()
        {
            Console.WriteLine("O " + this.name + " está pensando.");
            this.relatorio.incrementaRelatorio(this.name + " Pensou");
            this.relatorio.atualizaStatus(this.name + " Status", "Pensando");
        }
    }

}

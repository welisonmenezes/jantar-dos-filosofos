using System.Collections.Generic;
using System.Threading;

class Jantar
{

    public Relatorio relatorio;

    public Jantar(Relatorio relatorio)
    {
        this.relatorio = relatorio;
        List<Filosofo> filosofos = InicializaFilosofos(this.relatorio);

        Thread startAll = new Thread(new ThreadStart(() =>
        {
            List<Thread> filosofosThreads = new List<Thread>();
            foreach (Filosofo filosofo in filosofos)
            {
                Thread filosofoThread = new Thread(new ThreadStart(filosofo.ComecaAJanta));
                filosofosThreads.Add(filosofoThread);
                filosofoThread.Start();
            }
        }));

        startAll.Start();
    }

    private static List<Filosofo> InicializaFilosofos(Relatorio relatorio)
    {
        List<Filosofo> filosofos = new List<Filosofo>(5);
        for (int i = 0; i < 5; i++)
        {
            filosofos.Add(new Filosofo(filosofos, i, relatorio));
        }

        foreach (Filosofo filosofo in filosofos)
        {
            filosofo.garfoAEsquerda = new Mao(false);
            filosofo.garfoADireita = new Mao(false);
        }

        return filosofos;
    }
}

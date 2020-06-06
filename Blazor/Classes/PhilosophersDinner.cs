using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

class PhilosophersDinner
{
    private const int PHILOSOPHER_COUNT = 5;
    private PhilosopherReports reports;

    public PhilosophersDinner(PhilosopherReports reports)
    {
        var philosophers = InitializePhilosophers(reports);
        this.reports = reports;

        Thread startAll = new Thread(new ThreadStart(() =>
        {
            var philosopherThreads = new List<Thread>();
            foreach (var philosopher in philosophers)
            {
                var philosopherThread = new Thread(new ThreadStart(philosopher.EatAll));
                philosopherThreads.Add(philosopherThread);
                philosopherThread.Start();
            }

            foreach (var thread in philosopherThreads)
            {
                thread.Join();
            }
        }));
        startAll.Start();
    }

    private static List<Philosopher> InitializePhilosophers(PhilosopherReports reports)
    {
        var philosophers = new List<Philosopher>(PHILOSOPHER_COUNT);
        for (int i = 0; i < PHILOSOPHER_COUNT; i++)
        {
            philosophers.Add(new Philosopher(philosophers, i, reports));
        }

        foreach (var philosopher in philosophers)
        {
            philosopher.LeftChopstick = philosopher.LeftPhilosopher.RightChopstick ?? new Chopstick();
            philosopher.RightChopstick = philosopher.RightPhilosopher.LeftChopstick ?? new Chopstick();
        }

        return philosophers;
    }
}
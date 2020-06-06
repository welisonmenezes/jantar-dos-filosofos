using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

[DebuggerDisplay("Name = {Name}")]
public class Philosopher
{
    private const int TIMES_TO_EAT = 1000000000;
    private int _timesEaten = 0;
    private readonly List<Philosopher> _allPhilosophers;
    private readonly int _index;
    Stopwatch sw;
    private PhilosopherReports reports;

    public Philosopher(List<Philosopher> allPhilosophers, int index, PhilosopherReports reports)
    {
        _allPhilosophers = allPhilosophers;
        _index = index;
        this.Name = string.Format("Philosopher {0}", _index);
        this.State = State.Thinking;
        this.reports = reports;
    }

    public string Name { get; private set; }
    public State State { get; private set; }
    public Chopstick LeftChopstick { get; set; }
    public Chopstick RightChopstick { get; set; }

    public Philosopher LeftPhilosopher
    {
        get
        {
            if (_index == 0)
                return _allPhilosophers[_allPhilosophers.Count - 1];
            else
                return _allPhilosophers[_index - 1];
        }
    }

    public Philosopher RightPhilosopher
    {
        get
        {
            if (_index == _allPhilosophers.Count - 1)
                return _allPhilosophers[0];
            else
                return _allPhilosophers[_index + 1];
        }
    }

    public void EatAll()
    {
        sw = Stopwatch.StartNew();
        while (_timesEaten < TIMES_TO_EAT)
        {
            this.Think();
            Thread.Sleep(100);
            if (this.PickUp())
            {
                Thread.Sleep(100);
                this.Eat();
                Thread.Sleep(100);
                this.PutDownLeft();
                Thread.Sleep(100);
                this.PutDownRight();
                Thread.Sleep(100);
            }
            else
            {
                this.reports.makeChange(this.reports, this.Name + " Hunger");
                this.reports.makeStatus(this.reports, this.Name + " Status", "Esperando...");
                Thread.Sleep(100);
            }
            this.reports.makeStatus(this.reports, this.Name + " Time", sw.ElapsedMilliseconds+"");
        }
        sw.Stop();
        
    }

    private bool PickUp()
    {
        if (Monitor.TryEnter(this.LeftChopstick))
        {
            if (Monitor.TryEnter(this.RightChopstick))
            {
                return true;
            }
            else
            {
                this.PutDownLeft();
            }
        }
        return false;
    }

    private void Eat()
    {
        this.State = State.Eating;
        _timesEaten++;
        this.reports.makeChange(this.reports, this.Name + " Eats");
        this.reports.makeStatus(this.reports, this.Name + " Status", "Comendo...");

        if (_timesEaten == TIMES_TO_EAT)
        {
            this.reports.makeStatus(this.reports, this.Name + " Status", "Terminou.");
        }

    }

    private void PutDownLeft()
    {
        Monitor.Exit(this.LeftChopstick);
    }

    private void PutDownRight()
    {
        Monitor.Exit(this.RightChopstick);
    }


    private void Think()
    {
        this.State = State.Thinking;
        this.reports.makeChange(this.reports, this.Name + " Think");
        this.reports.makeStatus(this.reports, this.Name + " Status", "Pensando...");
    }
}
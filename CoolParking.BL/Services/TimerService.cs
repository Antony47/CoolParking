using CoolParking.BL.Interfaces;
using System;
using System.Timers;

public class TimerService : ITimerService
{
    private bool disposed = false;

    public double Interval { get; set; }

    public event ElapsedEventHandler Elapsed;

    private Timer timer;



    public void Dispose()
    {

        Dispose(true);
        
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                timer.Dispose();
            }

            
            disposed = true;
        }
    }

    public void Start()
    {
        timer = new Timer(Interval);
        timer.Elapsed += Elapsed;
        timer.Start();

    }

    public void Stop()
    {
        timer?.Stop();
    }
}

// TODO: implement class TimerService from the ITimerService interface.
//       Service have to be just wrapper on System Timers.

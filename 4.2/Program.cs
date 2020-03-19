using System;

namespace _4._2
{
    public delegate void action ();
    public class Time
    {
        public event action Work;
        public void Start()
        {
            Work();
        }
    }
    public class AlarmClock
    {
        static int i=0;
        public void TickAlarm(Time time)
        {
            
            time.Work += Tick;
            
            
            void Tick()
            {
                while (true)
                {
                    Console.WriteLine("滴答");
                    System.Threading.Thread.Sleep(1000);
                    i++;
                    if (i % 10 == 0)
                    {
                        Console.WriteLine("响铃!!!");
                    }
                }
                

            }
            
        }
    }   
    
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            AlarmClock alarmclock = new AlarmClock();
            alarmclock.TickAlarm(time);
            time.Start();

        }
    }
}

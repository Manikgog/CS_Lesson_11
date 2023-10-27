using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_11
{
    internal class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }   

        public override string ToString()
        {
            return Hour + ":" + Minute;
        }

        public static bool operator >(Time t1, Time t2)
        {
            if(t1.Hour > t2.Hour) { return true; }
            else if(t1.Hour == t2.Hour && t1.Minute > t2.Minute)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Hour < t2.Hour) { return true; }
            else if (t1.Hour == t2.Hour && t1.Minute < t2.Minute)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if (t1.Hour == t2.Hour && t1.Minute == t2.Minute) { return true; }
            return false;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            if(t1 == t2) { return false; }
            return true;
        }

        public static Time operator -(Time t1, Time t2)
        {
            int hour1 = (int)t1.Hour;
            int minute1 = (int)t1.Minute;
            int hour2 = (int)t2.Hour;
            int minute2 = (int)t2.Minute;
            
            int hour = hour1 - hour2;
            int minute = minute1 - minute2;
            Time t = new Time(hour, minute);
            return t;
        }

    }
}

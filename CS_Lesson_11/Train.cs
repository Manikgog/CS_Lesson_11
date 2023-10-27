using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_11
{
    internal struct Train
    {
        public int Number { get; set; }
        public string DeparturePoint { get; set; }

        public Time DepartureTime { get; set; }
        public string DepartureDate { get; set; }

        public Train(int number, string departurPoint, Time departureTime, string departureDate)
        {
            this.Number = number;
            this.DeparturePoint = departurPoint;
            this.DepartureTime = departureTime;
            this.DepartureDate = departureDate;
        }


        public void Info()
        {
            Console.WriteLine("Поезд номер: " + this.Number +
                            ", Пункт отправления: " + this.DeparturePoint +
                            ", Время отправления: " + this.DepartureTime +
                            ", Дата отправления: " + this.DepartureDate);
        }

        public void CheckArrivalTime(Time factArrivalTime)
        {
            Time time = this.DepartureTime - factArrivalTime;
            if(this.DepartureTime > factArrivalTime) 
            {
                Console.WriteLine("Поезд опоздал" + time);
            }else if(this.DepartureTime == factArrivalTime)
            {
                Console.WriteLine("Поезд пришёл вовремя");
            }
            else
            {
                Console.WriteLine("Поезд пришёл раньше времени");
            }
        }

    }
}

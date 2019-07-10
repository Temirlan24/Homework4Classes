using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class Plane
    {
        private static string airportName;
        private static short engineNumber;
        static Plane()
        {
            airportName = "Нур-Султана (TSE)";
            engineNumber = 4;
        }
        public void showResult()
        {
            Console.WriteLine("Дата вылета: "+time);
            Console.WriteLine("Пункт назначения - " + pointName);
            Console.WriteLine("Имя самолета - " + planeNumber);
            Console.WriteLine("Количество пассажирских мест  - " + seatNumbers);
            Console.WriteLine("Скорость самолета - " + speedPlane);
            Console.WriteLine("Вылет из - " + airportName);
            Console.WriteLine("Количество двигаетелей - " + engineNumber);
        }
    }
}

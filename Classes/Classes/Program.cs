using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Plane[] planes = new Plane[5];
            for (int i = 0; i < 5; i++)
            {
                planes[i] = new Plane();
            }
            DateTime time = new DateTime();
            planes[0].setPointName("Алматы (ALA)");
            planes[0].setTime(DateTime.Parse("2019/07/09 19:30"));
            planes[0].setPlaneNumber("TY-134");
            planes[0].setSeatNumbers(96);
            planes[0].setSpeedPlane(850);
            planes[0].showResult();
           
            Console.WriteLine();
            planes[1].setPointName("Москва (MOW)");
            planes[1].setTime(DateTime.Parse("2019/09/02 4:30"));
            planes[1].setPlaneNumber("TY-154");
            planes[1].setSeatNumbers(180);
            planes[1].setSpeedPlane(950);
            planes[1].showResult();
            Console.WriteLine();
            planes[2].setPointName("Прага (PRG)");
            planes[2].setTime(DateTime.Parse("2019/08/19 2:25"));
            planes[2].setPlaneNumber("Airbus A320");
            planes[2].setSeatNumbers(149);
            planes[2].setSpeedPlane(853);
            planes[2].showResult();
            Console.WriteLine();
            planes[3].setPointName("Дубай (DXB)");
            planes[3].setTime(DateTime.Parse("2019/07/28 3:45"));
            planes[3].setPlaneNumber("Boeing-747");
            planes[3].setSeatNumbers(298);
            planes[3].setSpeedPlane(917);
            planes[3].showResult();
            Console.WriteLine();
            planes[4].setPointName("Париж (PAR)");
            planes[4].setTime(DateTime.Parse("2019/07/31 8:00"));
            planes[4].setPlaneNumber("Airbus A310");
            planes[4].setSeatNumbers(183);
            planes[4].setSpeedPlane(858);
            planes[4].showResult();
            Console.ReadKey();
        }
    }
}

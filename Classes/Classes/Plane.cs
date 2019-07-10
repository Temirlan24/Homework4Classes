using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class Plane
    {
        private string pointName; // пункт назначения
        private DateTime time; //время вылета 
        private string planeNumber;
        private int seatNumbers;
        private int speedPlane;
        
        public Plane()
        {
            pointName = null;
            planeNumber = null;
            seatNumbers = 0;
            speedPlane = 0;
        }
        public Plane(string pointName, DateTime time, string planeNumber, int seatNumbers, int speedPlane)
        {
            this.pointName = pointName;
            this.time = time;
            this.planeNumber = planeNumber;
            this.seatNumbers = seatNumbers;
            this.speedPlane = speedPlane;
        }
       
        public string getPointName()
        {
            return pointName;
        }
        public void setPointName(string pointName)
        {
            this.pointName = pointName;
        }
        public DateTime getTime()
        {
            
            return time;
        }
        public void setTime(DateTime time)
        {
            this.time = time;

        }
        public string getPlaneNumber()
        {
            return planeNumber;
        }
        public void setPlaneNumber(string planeNumber)
        {
            this.planeNumber = planeNumber;
        }
        public int getSeatNumbers()
        {
            return seatNumbers;
        }
        public void setSeatNumbers(int seatNumbers)
        {
            this.seatNumbers = seatNumbers;
        }
        public int getSpeedPlane()
        {
            return speedPlane;
        }
        public void setSpeedPlane(int speedPlane)
        {
            this.speedPlane = speedPlane;
        }

        public static string getAirportName()
        {
            return airportName;
        }
        public static void setAirportName(string airportName_)
        {
            airportName = airportName_;
        }
      
    }
}


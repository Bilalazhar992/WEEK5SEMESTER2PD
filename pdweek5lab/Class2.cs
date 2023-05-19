using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdweek5lab
{
    public class Ship
    {
        public int serial_no;
        Angle longitudinal ;
        Angle latitudinal ;
        public Ship(Angle angle1,Angle angle2,int number)
        {
            longitudinal = angle1;
            latitudinal = angle2;
            serial_no = number;
        }
        public Ship()
        {

        }
        public Ship GiveShip(int number,List<Ship> ships)
        {
            foreach(Ship ship in ships)
            {
                if(ship.serial_no==number)
                {
                    return ship;
                }
            }
            return null;
        }
        public void ViewShip(Ship ship)
        {
            Console.WriteLine(ship.longitudinal.degrees + "*" + ship.longitudinal.minutes + "`" +ship.longitudinal.direction + " and " +ship.latitudinal.degrees + "*" + ship.latitudinal.minutes + "`" + ship.latitudinal.direction);
        }
        public Ship GiveSerialNo(List<Ship> ships)
        {
            foreach(Ship ship in ships)
            {
                if(longitudinal.degrees==ship.longitudinal.degrees && longitudinal.minutes==ship.longitudinal.minutes&& longitudinal.direction==ship.longitudinal.direction && latitudinal.degrees==ship.latitudinal.degrees && latitudinal.minutes==ship.latitudinal.minutes&&latitudinal.direction==ship.latitudinal.direction)
                {
                    return ship;
                }

            }
            return null;
        }
        public void ViewSerialNo()
        {
            Console.WriteLine(serial_no);
        }
    }
}

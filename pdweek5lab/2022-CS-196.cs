using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdweek5lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            Ship ship = new Ship();
            while(true)
            {
                string choice = main_menu();
                if(choice=="1")
                {
                    ships.Add(EnterShip(0));
                }
               else  if(choice=="2")
                {
                    FindShip(ship,ships);
                    if(ship==null)
                    {
                        Console.WriteLine("That Ship Does not Exsist in Our Record");
                    }
                    else
                    {
                        ship.ViewShip(ship);
                    }
                }
                else if(choice=="3")
                {
                    ship = EnterShip(1);
                    ship = ship.GiveSerialNo(ships);
                    if (ship == null)
                    {
                        Console.WriteLine("That Ship Does not Exsist in Our Record");
                    }
                    else
                    {
                        ship.ViewSerialNo();
                    }
                }
                else if (choice == "4")
                {
                    FindShip(ship, ships);
                    if (ship == null)
                    {
                        Console.WriteLine("That Ship Does not Exsist in Our Record");
                    }
                    else
                    {
                        ship=EnterShip(1);
                    }
                }
                else if (choice =="5")
                {
                    break;
                }
                Console.WriteLine("Press Any Key TO Go Back on MainMenu ");
                Console.ReadKey();
                Console.Clear();
            }
            


        }
        static string main_menu()
        {
            string option;
            Console.WriteLine("1-Add Ship");
            Console.WriteLine("2-View Ship Position");
            Console.WriteLine("3-View Ship Serial Number");
            Console.WriteLine("4-Change Ship Position");
            Console.WriteLine("5-Exit");
            Console.WriteLine("Enter Your Choice");
            return option = Console.ReadLine();
        }
        static Ship EnterShip(int index)
        {
            int number=0;
            if(index==0)
            {
                Console.WriteLine("Enter Ship Serial Number");
                number = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Enter Longitude Credentials");
            Console.WriteLine("Enter degree value");
            int degree1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minute value");
            int minute1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction (You Can Only Enter East or West Direction)");
            string direction1 = Console.ReadLine();
            Console.WriteLine("Enter Latitude Credentials");
            Console.WriteLine("Enter degree value");
            int degree2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minute value");
            int minute2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction (You Can Only Enter North or South Direction)");
            string direction2 = Console.ReadLine();
            Angle angle1 = new Angle(degree1, minute1, direction1);
            Angle angle2 = new Angle(degree2, minute2, direction2);
            Ship ship = new Ship(angle1, angle2, number);
            return ship;
        }
        static void FindShip(Ship ship,List<Ship>ships)
        {
            Console.WriteLine("Enter Serial Number of Ship");
            int number = int.Parse(Console.ReadLine());
            ship = ship.GiveShip(number, ships);
        }
    }
}

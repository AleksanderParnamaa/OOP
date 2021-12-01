using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string name;
            string model;
            string regnumber;
            string color;
            int odometer;
            int fueltank;
            //constructor
            public Car(string _name)
            {
                name = _name;
                model = "2";
                regnumber = "123456";
                odometer = 0;
                fueltank = 60;
                color = "purple";


            }
            public void Drive()
            {
                fueltank -= 5;
                odometer += 100;
                Console.WriteLine("wroom wroom");
            }

            public void ShowCarInfo()
            {
                Console.WriteLine($"Name: {name}.");
                Console.WriteLine($"Model:{model}");
                Console.WriteLine($"RegistrationNumber:{regnumber}");
                Console.WriteLine($"Color:{color}");
                Console.WriteLine($"Odometer:{odometer}");
                GC.Collect();
            }

            static void Main(string[] args)
            {
                Car myCar = new Car("Nissan");
                myCar.ShowCarInfo();
                for (int i = 0;i < 12;i++)
                {
                    myCar.Drive();
                    Console.WriteLine($"Fuel:{myCar.fueltank}");
                    Console.WriteLine($"Odometer:{myCar.odometer}");
                    if (myCar.fueltank == 0)
                    {
                        while (myCar.fueltank == 0)
                        { 
                         Console.WriteLine($"Out of fuel:{myCar.fueltank}"); 
                        }
                      
                        
                    
                    }
                }
            }
        }
    }
}

    

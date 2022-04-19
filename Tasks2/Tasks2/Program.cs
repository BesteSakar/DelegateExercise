using System;

namespace Tasks2
{
    internal class Program
    {

        delegate int SpeedCar(int speed);
        static void Main(string[] args)
        {


            SpeedCar car1 = new SpeedCar(printSpeed);
            Console.WriteLine("Your car model is"+" "+Car_models.Toyota);
            Console.WriteLine("Your speed is" + " "+printSpeed(120));
            

        }
        enum Car_models
        {
            Toyota,
            BMW,
            Mercedes
        }




        static int  printSpeed(int speed)
        {
            if(speed > 100)
            {
                Console.WriteLine("Your speed is high..Please slow down..");
            }
            else
            {
                Console.WriteLine("Your speed is normal..");
            }
            return speed;
           
        }


    }
}

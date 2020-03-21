using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1.Models
{
    public abstract class Car
    {
        public double Acceleration { get; protected set; } = 10;

        public double Speed { get; protected set; } = 100;

        public void Start()
        {
            Console.WriteLine("Turning on the engine...");
            Console.WriteLine($"Running at: {Speed.ToString()} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating...");
            Speed += Acceleration;
            Console.WriteLine($"Running at: {Speed.ToString()} km/h.");
        }

        public abstract void Boost();
        
    }

    public class Truck : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a truck...");
            base.Accelerate();
        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a truck...");
            Speed += 50;
            Console.WriteLine($"Running at: {Speed.ToString()} km/h.");
        }
    }

    public class SportCar : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a sportCar...");
            base.Accelerate();
        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a sport car...");
            Speed += 100;
            Console.WriteLine($"Running at: {Speed.ToString()} km/h.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Sport car.");
        }
    }

    public class Race
    {
        public void Begin()
        {
            Car sportCar = new SportCar();
            Car truck = new Truck();

            List<Car> cars = new List<Car>
            {
                sportCar, truck
            };

            foreach (Car car in cars)
            {
                car.Start();
                car.Accelerate();
                car.Boost();
            }

        }

        public void Casting()
        {
            Car sportCar = new SportCar();
            Car truck = new Truck();

            
            // DOWN CASTING - RZUTOWANIE W DÓŁ
            //SportCar realSportCar = (SportCar)sportCar; //(SportCar) - nazwa typu na który chcemy rzutować sportCar - zmienna którą rzutujemy
            //realSportCar.DisplayInfo();

            //UP CASTING -RZUTOWANIE W GÓRĘ
            //Car realCar = (Car)realSportCar;
            //realCar.

            //bool isSportCar = sportCar is SportCar;
            //if(isSportCar)
            //{
            //    ((SportCar)sportCar).DisplayInfo();
            //}

            SportCar castedSportCar = sportCar as SportCar;
            if(sportCar != null)
            {
                castedSportCar.DisplayInfo();
            }

        }
    }
}

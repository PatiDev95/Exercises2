using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Episode1.Models
{
    public class Delegates
    {
        public delegate void Write(string message);
        public delegate int Add(int x, int y);
        public delegate void Alert(int change);

        public void Test()
        {
            Write writer = WriteMessage;
            Add adder = AddTwoNumbers;
            writer("Piotr");
            var sum = adder(1, 2);
            Console.WriteLine(sum);
            CheckTemperature(TooLowAlert, OptimalAlert, TooHighAlert);
        }

        public static void TooLowAlert(int change)
        {
            Console.WriteLine($"Temperature is too low (change by {change}).");
        }
        public static void OptimalAlert(int change)
        {
            Console.WriteLine($"Temperature is optimal (change by {change}).");
        }
        public static void TooHighAlert(int change)
        {
            Console.WriteLine($"Temperature is too high (change by {change}).");
        }

        public static void CheckTemperature(Alert tooLow, Alert optimal, Alert tooHigh)
        {
            var temperature = 10;
            var random = new Random();

            while(true)
            {
                var change = random.Next(-5, 5);
                temperature += change;
                Console.WriteLine($"Temperature is at: {temperature} C.");
                if (temperature <= 0)
                {
                    tooLow(change);
                }
                else if (temperature > 0 && temperature <= 10)
                {
                    optimal(change);
                }
                else 
                {
                    tooHigh(change);
                }
                Thread.Sleep(500);
            }
        }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine($"Hello {message} !");
        }
    }
}

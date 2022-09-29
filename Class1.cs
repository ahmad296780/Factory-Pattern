using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class VehicleFactory
    {
        public static IVehicle BuildCar(int user)
        {
            if (user == 4)
            {
                return new Car();
            }
            else if (user == 2)
            {
                return new Motorcycle();
            }
            else
            {
                return null;
            }
        }
    }
    public interface IVehicle
    {
        public void drive();
    }
    public class Car : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("here is your new car"); ;
        }
    }
    public class Motorcycle : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("here is your new motorcycle"); ;
        }

    }
}

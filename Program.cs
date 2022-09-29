
using Factory_Pattern;
using System.Data.SqlTypes;

Console.WriteLine("How many tires on vehicle?");
var user = Int32.Parse(Console.ReadLine());

IVehicle vehicle = VehicleFactory.BuildCar(user);
vehicle.drive();
Console.ReadLine();
namespace Project14_OOP2;

using Project14_OOP2.Models;


class Program
{
    static void Main(string[] args)
    {
        // Car car1 = new Car();
        // Car car1 = new(); // initialize
        // car1.Brand = "Opel";
        // car1.Model = "Corsa";
        // car1.CurrentSpeed = 100;
        // car1.YearOfProduction = 2022;

        Car car1 = new()
        {
            Brand = "Opel",
            Model = "Corsa",
            CurrentSpeed = 100,
            YearOfProduction = 2022
        };

        car1.SpeedUp(10);
        car1.SlowDown(50);
        car1.SlowDown(50);
        car1.SlowDown(-5);
        // car1.SlowDown(30);


    }
}






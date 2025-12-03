namespace Project14_OOP2.Models;

public class Car
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int YearOfProduction { get; set; }
    public double CurrentSpeed { get; set; }

    public void SpeedUp(double increase)
    {
        CurrentSpeed += increase;
        Console.WriteLine($"{Brand} {Model} hızlanıyor... Yeni hızı: {CurrentSpeed} km/h");
    }

    public void SlowDown(double decrease)
    {
        if (decrease > 0)
        {
            if ((CurrentSpeed - decrease) >= 0)
            {
                CurrentSpeed -= decrease;
            }
            else
            {
                CurrentSpeed = 0;
            }

            Console.WriteLine
            (
                CurrentSpeed == 0
                    ? $"{Brand} {Model} durdu..."
                    : $"{Brand} {Model} yavaşlıyor... Yeni hızı: {CurrentSpeed} km/h"
            );

        }

    }
}








// if (CurrentSpeed == 0)
// {
//     Console.WriteLine($"{Brand} {Model} durdu...");
// }
// else
// {
//     Console.WriteLine($"{Brand} {Model} yavaşlıyor... Yeni hızı: {CurrentSpeed} km/h");
// }
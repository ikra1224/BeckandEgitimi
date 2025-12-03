/*
1. Akıllı Termostat Simülatörü: Mevcut sıcaklık, hedef sıcaklık ve klimanın durumunu tutan değişkenler oluşturun. Mevcut sıcaklık hedeften 2 derece fazlaysa VE klima kapalıysa, klimanın açılması gerektiğini (true) belirten bir bool değişkeni hesaplayıp yazdırın.
*/


namespace HomeWork01;

class Program
{
    static void Main()
    {
        double currentTemperature = 24.5;
        double targetTemperature = 22.0;
        bool isACOn = false;

        bool shouldTurnOnAC = (currentTemperature > targetTemperature + 2) && !isACOn;

        Console.WriteLine("Mevcut Sıcaklık: " + currentTemperature + "°C");
        Console.WriteLine("Hedef Sıcaklık: " + targetTemperature + "°C");
        Console.WriteLine("Klima Durumu: " + (isACOn ? "Açık" : "Kapalı"));
        Console.WriteLine("Klima Açılsın mı? " + (shouldTurnOnAC ? "Evet" : "Hayır"));
    }
}
using System;

namespace Mobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mengisi properti
            carClass Car1 = new carClass();
            Car1.Color = "Merah";
            Car1.Brand = "Ferarri";
            Car1.Type = "SF90";
            Car1.Horn = "Ngonggg~";
            Car1.Doors = 2;
            Car1.Since = 2023;
            Car1.Speed = 320;

            // memanggil metode
            Car1.Gas(Car1.Speed);
            Car1.Klakson(Car1.Horn);
            Car1.TampilkanInfo();

            Console.ReadKey();
        }
    }
}
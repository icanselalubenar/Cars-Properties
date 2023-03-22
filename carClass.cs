using System;
namespace Mobil
{
    public class carClass
    {
        // Properties
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Horn { get; set; }
        public int Doors { get; set; }
        public int Since { get; set; }
        public int Speed { get; set; }

        // Method 1
        public void Gas(int kecepatan)
        {
            Console.WriteLine("Method 1:");
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} Km/h.\n", Type, kecepatan);
        }
        // Method 2
        public void Klakson(string suara)
        {
            Console.WriteLine("Method 2:");
            Console.WriteLine("{0}\n", suara);
        }
        // Method 3
        public void TampilkanInfo()
        {
            Console.WriteLine("Method 3:");
            Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3}\ndengan jumlah pintu sebanyak {4}.", Color, Brand, Type, Since, Doors);
        }
    }
}


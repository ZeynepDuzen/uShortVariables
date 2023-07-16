using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uShortVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ushort sayi1,sayi2,toplam;
            //sayi1 = 30;
            //sayi2 = 10;
            //toplam =(ushort)(sayi1 + sayi2);
            //Console.WriteLine(toplam);

            //klavyeden girilen cevre ve alan hesaplamaları (dikdörtgen)
            ushort kisaKenar, uzunKenar, cevre, alan;
            Console.WriteLine("Lütfen dikdörtgenin kısa kenar ölçüsünü girin : ");
            kisaKenar = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen dikdörtgenin uzun kenar ölçüsünü girin : ");
            uzunKenar = ushort.Parse(Console.ReadLine());
            cevre = (ushort)(2*(kisaKenar+uzunKenar));
            alan = (ushort)(uzunKenar*kisaKenar);
            Console.WriteLine("Cevre : " + cevre);
            Console.WriteLine("Alan : " + alan);
            
            Console.Read();
        }
    }
}

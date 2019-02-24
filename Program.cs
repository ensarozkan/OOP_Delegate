using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kettle k = new Kettle();
            k.SuKaynamaEventi += SuKaynadi;
            //Console.WriteLine("Su sicakligi 70");
            //k.Susicakligi = 70;
            //Console.WriteLine("Su sicakligi 105");
            //k.Susicakligi = 105;
            //k.SicaklikArttir(70);
            //k.SicaklikArttir(35);
            //k.SicaklikArttir(); // 10 arttýrýr
            //Console.ReadKey();

            Kettle k2 = new Kettle();
            k2.SuKaynamaEventi += ElektrigiKapat;
            //Console.WriteLine("Su sicakligi 110");
            //k2.Susicakligi = 110;
            //Console.WriteLine("Su sicakligi 125");
            //k2.Susicakligi = 125;

            for (int i = 0; i < 10; i++)
            {
                byte n = (byte)Faker.RandomNumber.Next(95,110);
                Console.WriteLine("Su sicakligi {0}",n);
                k.Susicakligi = n;
            }
            Console.ReadKey();
            Console.WriteLine("******************");
            for (int i = 0; i < 10; i++)
            {
                byte n = (byte)Faker.RandomNumber.Next(95, 110);
                Console.WriteLine("Su sicakligi {0}", n);
                k2.Susicakligi = n;
            }
            Console.ReadKey();
        }
        static void SuKaynadi()
        {
            Console.WriteLine("Su Kaynadi");
            Console.ReadKey();
        }
        static void ElektrigiKapat()
        {
            Console.WriteLine("Kettle'in elektrigini kapatin.");
            Console.ReadKey();
        }
    }
}

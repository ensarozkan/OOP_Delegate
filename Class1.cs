using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    //public delegate void SuKaynamaDelege();

    public class Kettle
    {
        int i;
        //public event SuKaynamaDelege SuKaynamaEventi;
        public Action SuKaynamaEventi;
        private byte _susicakligi;
        public void SicaklikArttir(byte deger = 10)
        {
            Susicakligi += deger;
            Console.WriteLine("Şu anki sıcaklık "+ _susicakligi);
        }
        public byte Susicakligi
        {
            get
            {
                return _susicakligi;
            }
            set
            {
                _susicakligi = value;
                //Katte'in içerisindeki su sıcaklığı 100 derece olduğunda su kaynatma eventini tetikler.
                if (_susicakligi >= 100)
                {
                    //if (SuKaynamaEventi != null)
                    //{
                    //    SuKaynamaEventi();
                    //}
                    SuKaynamaEventi?.Invoke();
                }
            }
        }
    }
}

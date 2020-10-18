using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P2_096
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            return a / b;
        }

        public int Kali(int a, int b)
        {
            return a * b;
        }

        public int Kurang(int a, int b)
        {
            return a - b;
        }

        public int Tambah(int a, int b)
        {
            return a + b;
        }

        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            Koordinat hasil = new Koordinat();
            hasil.X = a.X + b.X;
            hasil.Y = a.Y + b.Y;
            return hasil;
        }

        [DataContract]
        public class Koordinat
        {
            private int _x, _y; //atribut
            [DataMember]//membuka koordinat, x,y
            public int X //properties
            {
                get { return _x; }
                set { _x = value; }
            }
            [DataMember]
            public int Y //properties
            {
                get { return _y; }
                set { _y = value; }
            }
        }
    }
}

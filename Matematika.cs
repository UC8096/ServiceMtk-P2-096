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

            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda MAsukan Salah";
                mf.Pesan = "Masukan Input yang bener";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kali(int a, int b)
        {

            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda MAsukan Salah";
                mf.Pesan = "Masukan Input yang bener";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kurang(int a, int b)
        {

            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda MAsukan Salah";
                mf.Pesan = "Masukan Input yang bener";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Tambah(int a, int b)
        {

            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda MAsukan Salah";
                mf.Pesan = "Masukan Input yang bener";
                throw new FaultException<MathFault>(mf);
            }
        }
        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, yadengan yb lalu dimasukkan ke hasil
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {


            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda MAsukan Salah";
                mf.Pesan = "Masukan Input yang bener";
                throw new FaultException<MathFault>(mf);
            }
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

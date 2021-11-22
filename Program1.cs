using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba_class
{
    class Program
    {
        static void Main(string[] args)
        {
            araba mycar = new araba("Opel", "siyah", 3, 12313, "Dizel");
            mycar.getir();
            Console.Read();
        }

        class araba
        {
            string model;
            string renk;
            byte yas;
            int km;
            string yakıt;

            public araba(string model, string renk, byte yas, int km, string yakıt)
            {
                this.model = model;
                this.renk = renk;
                this.yas = yas;
                this.km = km;
                this.yakıt = yakıt;
            }
            public void getir()
            {
                Console.Write("Model: {0} Renk: {1} Yas: {2} km: {3} yakıt: {4}", model, renk, yas, km, yakıt);
            }

        }



    }
}

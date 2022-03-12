// See https://aka.ms/new-console-template for more information

using System;

namespace modul3_1302204068
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah objekBuah = new KodeBuah();

            KodeBuah.Fruit inputNamaBuah = KodeBuah.Fruit.Pisang;

            Console.WriteLine(objekBuah.getKodeBuah(inputNamaBuah));

        }

    }

}



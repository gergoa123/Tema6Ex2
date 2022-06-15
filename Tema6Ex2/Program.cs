using System;

namespace Tema6Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Autoturism a1 = new Autoturism("Matiz", "69 LoL", 1);
            Autoturism a2 = new Autoturism("Pollo", "420 GaS", 4);

            a1.Tipareste();
            a2.Tipareste();


        }
    }
}

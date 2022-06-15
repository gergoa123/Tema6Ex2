using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6Ex2
{
    class Autoturism
    {
        string marca;
        string numarDeInmatriculare;
        int capacitateCilindrica;

        public Autoturism(string marca, string numarDeInmatriculare , int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarDeInmatriculare = numarDeInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public void Tipareste()
        {
            Console.WriteLine(marca + ", " + numarDeInmatriculare + ", " + capacitateCilindrica);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    //----------- Classe rettangolo --------------
    public class Rettangolo
    {

        private int baseRettangolo;
        private int altezzaRettangolo;
        private int area;
        private int perimetro;

        //----------- Costruttore ------------
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {

            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;

        }

        //----------- Metodo 1 perimetro rettangolo --------------

        public int perimetroRettangolo()
        {

            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int perimetro = baseRettangolo + altezzaRettangolo + baseRettangolo + altezzaRettangolo;
            this.perimetro = perimetro;
            return this.perimetro;

        }

        //------------- Metodo 2 area rettangolo -----------------
        public int areaRettangolo()
        {

            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int area = baseRettangolo * altezzaRettangolo;
            this.area = area;
            return this.area;

        }

        //-------------- Metodo 3 stampa dati rettangolo ------------
        public void stampaRettangolo()
        {
            Console.WriteLine("------- RETTANGOLO -------");
            Console.WriteLine("Base: " + baseRettangolo + " cm.");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm.");
            Console.WriteLine("Perimetro: " + perimetro + " cm.");
            Console.WriteLine("Area: " + area + " cm2");
            Console.WriteLine("--------------------------");

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS
{
    internal class Class1
    {

        private int baseRettangolo;
        private int altezzaRettangolo;
        private int area;
        private int perimetro;

        //----------- Costruttore ------------
        public Class1(int baseRettangolo, int altezzaRettangolo)
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

        //------------ Metodo 4 disegna rettangolo ------------------

        public void disegnoRettangolo()
        {
            for (int i = 0; i < altezzaRettangolo; i++)
            {
                for (int j = 0; j < baseRettangolo; j++)
                {
                    
                    if (i == 0 || i == (altezzaRettangolo - 1))
                    {
                        Console.Write("-");

                    }
                    
                    else if (j == 0 || j == (baseRettangolo - 1))
                    {
                        Console.Write("|");
                    }
                    
                    else
                    {
                        Console.Write(" ");
                    }
                }
                
                Console.Write("\n");
            }
        }
    }
}

        
    



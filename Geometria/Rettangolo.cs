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


        //----------- Costruttore ------------
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {

            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;

        }

        //----------- Metodo 1 perimetro rettangolo --------------

        public void perimetroRettangolo()
        {

            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int perimetro = baseRettangolo + altezzaRettangolo * 2;


        }

        //------------- Metodo 2 area rettangolo -----------------
        public void areaRettangolo()
        {

            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int area = baseRettangolo * altezzaRettangolo;

        }
    }

}

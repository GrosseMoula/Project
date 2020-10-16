using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_PlateformeNet
{
    class Mesure
    {
        private int ID;
        private string format;
        private string Type;
        private int min;
        private int max;
        public int valeur;
        
        private static int cpt;

        public Mesure(String format, String type, int min,int max,int valeur)
        {
            this.ID = cpt++;
            this.format = format;
            this.Type = type;
            this.min = min;
            this.max = max;
            this.valeur = valeur;
        }

        public int getID { get => ID; set => ID = value; }

        public int getValeur { get => valeur; set => valeur = value; }
        public string getformat { get => format; set => format = value; }
        public int getmin { get => min; set => min = value; }
        public int getmax { get => max; set => max = value; }
        public string getType { get => Type; set => Type = value; }





    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TOF.Spell
{
    public abstract class Spells
    {
        public string Nom { get; set; }
        public int Degat { get; set; }
        public string Effet { get; set; }
        // 0 veut dire pas d'effet de zone, 1 veut dire effet de zone vertical, 2 effet horizontale
        public int Zone { get; set; }
        public int Cout { get; set; }

        public bool TypeMagique { get; set; }

        public Spells(string nom, int deg, string effet, int zone, int cout, bool typemagique)
        {
            this.Nom = nom;
            this.Degat = deg;
            this.Effet = effet;
            this.Zone = zone;
            this.Cout = cout;
            this.TypeMagique = typemagique;
        }

        public Spells()
        {
        }

        public string PrintName()
        {
            return this.Nom;
        }

        public string PrintDegat()
        {
            return "" + this.Degat;
        }

        public string PrintEffet()
        {
            return this.Effet;
        }

        public string PrintZone()
        {
            switch (this.Zone)
            {
                case 1:
                    return "zone d'effet vertical";
                case 2:
                    return "zone d'effet horizontal";
                default:
                    return "pas de zone d'effet";
            }
        }

        public string PrintCout()
        {
            return "" + this.Cout;
        }

        public string PrintTypeMagiue()
        {
            if (this.TypeMagique == true)
            {
                return "Magique";
            }
            else
            {
                return "Non magique";
            }
        }
    }
}

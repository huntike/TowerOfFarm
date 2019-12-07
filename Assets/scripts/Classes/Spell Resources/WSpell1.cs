using System;
using System.Collections.Generic;
using System.Text;

namespace TOF.Spell
{
    public class WSpell1 : Spells
    {
        public WSpell1()
        {
            this.Nom = "la feinte";
            this.Degat = 5;
            this.Effet = "Lourd, léger, professionnel";
            this.Zone = 0;
            this.Cout = 5;
            this.TypeMagique = false;
        }

        public WSpell1(string nom, int deg, string effet, int zone, int cout, bool typemagique) : base(nom, deg, effet, zone, cout, typemagique)
        {

        }
    }
}

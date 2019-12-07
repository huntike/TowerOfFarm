using System;
using System.Collections.Generic;
using System.Text;

namespace TOF.Spell
{
    public class WSpell2 : Spells
    {


        public WSpell2()
        {
            this.Nom = "la patate";
            this.Degat = 10;
            this.Effet = "lourde baffe";
            this.Zone = 0;
            this.Cout = 10;
            this.TypeMagique = false;
        }
        public WSpell2(string nom, int deg, string effet, int zone, int cout, bool typemagique) : base(nom, deg, effet, zone, cout, typemagique)
        {
            
        }
    }
}

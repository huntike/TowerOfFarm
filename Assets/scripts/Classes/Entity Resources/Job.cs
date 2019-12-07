using System;
using System.Collections.Generic;
using System.Text;
using TOF.Spell;

namespace TOF.Entities
{
    public class Job
    {

        public string Name { get; set; }
        public List<Spells> Spells { get; set; }
        protected List<int> Bonus { get; set; }

        public Job(string name)
        {
            this.Name = name;
            this.Bonus = null;
            this.Spells = new List<Spells>();
            this.Spells.Add(new WSpell1("Attaque de forrain", 20 , "une attaque très puissante c'est mort", 0,10,false));
            this.Spells.Add(new WSpell2("Attaque éclair", 10, "une attaque très rapide c'est mort", 0, 5, false));
        }

        public string PrintNameClass()
        {
            return "la classe est : " + this.Name;
        }
    }
}

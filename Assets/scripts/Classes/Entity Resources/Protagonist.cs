using System;
using System.Collections.Generic;
using System.Text;
using TOF.Spell;

namespace TOF.Entities
{
    /**
     * @author Nummy
     * @version 0.1
     */
    public class Protagonist : Entity
    {

        public Job Job { get; private set; }
        public List<Spells> SpellsUse { get; set; }
        public string Gender { set; get; }
        public int Helmet { set; get; }
        public int Body { set; get; }
        public int Weapon { set; get; }
        public int Shield { set; get; }
        public int Exp { set; get; }

        /**
        * @author Nummy
        * @version 0.1
        */
        public Protagonist(string id, Job job, GlobalStats primary, int level, int exp) : base(primary, level, id)
        {
            this.id = id;
            this.Job = job;
            this.Primary = primary;
            this.Level = level;
            this.Exp = exp;
            this.Helmet = 2;
            this.Body = 2;
            this.Weapon = 2;
            this.Shield = 2;
            this.SpellsUse = new List<Spells>(4);

        }
        /**
         * @author Nummy
         * @version 0.1
         */
        public void CastSpell(Spells spell)
        {

        }

        public void AddSpell(Spells spell)
        {
            this.SpellsUse.Add(spell);
        }

        public string PrintName()
        {
            return "Nom : " + this.id;
        }

        public string PrintGender()
        {
            return "Sexe  : " + this.Gender;
        }

        public string PrintHelmet()
        {
            return "Point d'armure du casque : " + this.Helmet;
        }

        public string PrintBody()
        {
            return "Point d'armure du torse : " + this.Body;
        }

        public string PrintShield()
        {
            return "Point d'armure du bouclier : " + this.Shield;
        }

        public string PrintWeapon()
        {
            return "dégat de l'épée : " + this.Weapon;
        }
    }
}

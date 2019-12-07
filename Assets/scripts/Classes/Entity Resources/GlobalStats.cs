using System;
using System.Collections.Generic;
using System.Text;

namespace TOF.Entities
{
    /**
    * @author Nummy
    * @version 0.1
    **/
    public class GlobalStats
    {
        //Primary Stats
        public int Force { get; set; }
        public int Dexterite { set; get; }
        public int Inteligence { set; get; }
        public int Sagesse { set; get; }
        public int Charisme { set; get; }
        public int Constitution { set; get; }

        //Secondary stats
        public int HealthPoint { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public int ResistanceDamageM { set; get; }
        public int ResistanceDamageP { set; get; }
        public int ResistanceMental { set; get; }
        public int Initiative { set; get; }


        /**
        * @author Nummy
        * @version 0.1
        **/
        public GlobalStats(int f, int d, int i, int s, int c, int ch)
        {
            this.Force = f;
            this.Dexterite = d;
            this.Inteligence = i;
            this.Sagesse = s;
            this.Charisme = ch;
            this.Constitution = c;
            this.HealthPoint = c + 20;
            this.Mana = i + 20;
            this.Stamina = c + 20;
            this.ResistanceDamageM = s / 4;
            this.ResistanceDamageP = c / 4;
            this.ResistanceMental = s / 4;


        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public GlobalStats()
        {

            this.Force = 10;
            this.Dexterite = 10;
            this.Inteligence = 10;
            this.Sagesse = 10;
            this.Charisme = 10;
            this.Constitution = 10;
            this.HealthPoint = this.Constitution + 20;
            this.Mana = this.Inteligence + 20;
            this.Stamina = this.Constitution + 20;
            this.ResistanceDamageM = this.Sagesse / 4;
            this.ResistanceDamageP = this.Constitution / 4;
            this.ResistanceMental = this.Sagesse / 4;
            this.Initiative = this.Dexterite / 2;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public void RegenMana()
        {
            this.Mana += 5;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public void RegenStamina()
        {
            this.Stamina += 5;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintForce()
        {
            return "Force : " + this.Force;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintDext()
        {
            return "Dexterité : " + this.Dexterite;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintConst()
        {
            return "Constitution : " + this.Constitution;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintCharis()
        {
            return "Charisme : " + this.Charisme;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintSagesse()
        {
            return "Sagesse : " + this.Sagesse;

        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintHp()
        {
            return "Points de vie : " + this.Force;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintMana()
        {
            return "Points de mana : " + this.Mana;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintStamina()
        {
            return "Points de stamina : " + this.Stamina;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintResdegM()
        {
            return "Resistance aux dégats magiques : " + this.ResistanceDamageM;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintResDegP()
        {
            return "Résistance aux dégats physiques: " + this.ResistanceDamageP;
        }

        /**
         * @author Nummy
         * @version 0.1
         */
        public string PrintResM()
        {
            return "Résistance Mental : " + this.ResistanceMental;
        }
    }
}

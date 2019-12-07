using System;
using System.Collections.Generic;
using System.Text;
//using UnityEngine;

namespace TOF.Entities
{
    /**
     * @author Nummy  
     * @version 0.1
     */
    public abstract class Entity
    {

        //public string type { get; set; }
        public GlobalStats Primary { set; get; }
        public int Level { set; get; }
        public string id;

        public int actualHP;
        public int actualMP;
        public State etat = State.PROCESSING;

        public enum State
        {
            START,
            PROCESSING,
            ACTION,
            DEAD,
        }


        /**
         * @author Nummy  
         * @version 0.1
         */
        public Entity(GlobalStats primary, int level, string id)
        {
            this.Primary = primary;
            this.Level = level;
            this.actualHP = primary.HealthPoint;
            this.id = id;
            
        }

        /**
         * @author Nummy  
         * @version 0.1
         */
        public virtual void Attaque()
        {

        }

        public string PrintLevel()
        {
            return "level : " + this.Level;
        }

        public bool isDead()
        {
            if (actualHP <= 0)
                return true;
            return false;
        }

        public bool Equals(Entity other)
        {
            if (this.id == other.id)
                return true;
            return false;
        }

        public string PrintHP()
        {
            return UnityEngine.Mathf.Clamp(actualHP, 0f, (float)Primary.HealthPoint) + "/" + Primary.HealthPoint;
        }
        public string PrintMP()
        {
            return (actualMP + "/" + Primary.Mana);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;

            if (this.id == other.id)
                return true;
            return false;

        }

    }
}

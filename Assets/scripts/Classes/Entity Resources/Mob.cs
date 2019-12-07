using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TOF.Entities
{
    public class Mob : Antagonist
    {
        public Mob(GlobalStats primary, int level, string id) : base(primary, level, id)
        {
            this.id = id;
        }

        public void attack(Protagonist protagonist)
        {
            protagonist.actualHP -= this.primary.Force;
            Debug.Log(id + "inflige " + this.primary.Force + "dégats à " + protagonist.id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TOF.Entities
{
    public abstract class Antagonist : Entity
    {
        public GlobalStats primary { set; get; }
        public int level { set; get; }

        public Antagonist(GlobalStats primary, int level, string id) : base (primary, level, id)
        {
            this.primary = primary;
            this.level = level;
            this.id = id;
        }

        //use getter as a print function


    }
}

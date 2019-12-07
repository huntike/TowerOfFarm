using System;
using System.Collections.Generic;
using System.Text;

namespace TOF.Entities
{
    public class Hero : Protagonist
    {
        public int NbCapacity { get; set; }

        public Hero(string id, Job job, GlobalStats primary, int level, int exp) : base(id, job,primary,level, exp)
        {
            this.NbCapacity = 4;
        }
        
    }
}

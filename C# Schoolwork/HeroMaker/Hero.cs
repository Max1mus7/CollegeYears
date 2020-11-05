using System;
using System.Collections.Generic;
using System.Text;

namespace HeroMaker
{
    public class Hero
    {
        public List<bool> Powers { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PowerDate { get; set; }
        public int DarkSidePropensity { get; set; }
        public string PowersGainedBy { get; set; }
        public int AttackVal { get; set; }
        public int DefenseVal { get; set; }
        public int HealthVal { get; set; }

        public Hero(List<bool> powers, string description, string name, string powerDate, int darkSidePropensity, string powersGainedBy, int attackVal, int defenseVal, int healthVal)
        {
            Powers = powers;
            Description = description;
            Name = name;
            PowerDate = powerDate;
            DarkSidePropensity = darkSidePropensity;
            PowersGainedBy = powersGainedBy;
            AttackVal = attackVal;
            DefenseVal = defenseVal;
            HealthVal = healthVal;
        }
    }
}

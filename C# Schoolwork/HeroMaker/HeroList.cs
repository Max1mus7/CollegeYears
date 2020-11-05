using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace HeroMaker
{
    public partial class HeroList : Form
    {
        string newline = Environment.NewLine;
        List<Hero> heroes = new List<Hero>();
        public HeroList(List<Hero> heroesIn)
        {
            InitializeComponent();
            heroes = heroesIn;
            for(int i = 0; i < heroes.Count; i++)
            {
                lbNames.Items.Add(heroes[i].Name);
            }
            if(lbNames.Items.Count > 0)
            {
                lbNames.SelectedIndex = 0;
            }
        }

        private void lbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string description = "==============Abilites==============";
            if(heroes[lbNames.SelectedIndex].Powers[14] || heroes[lbNames.SelectedIndex].Powers[15] || heroes[lbNames.SelectedIndex].Powers[16])
            {
                description += newline + "Super-Special Ability:";
                if(heroes[lbNames.SelectedIndex].Powers[14])
                {
                    description += newline + "Time Control";
                }
                else if(heroes[lbNames.SelectedIndex].Powers[15])
                {
                    description += newline + "Reality Control";
                }
                else
                {
                    description += newline + "Immunity";
                }
            }
            description += newline + "Powers:";
            if(heroes[lbNames.SelectedIndex].Powers[0])
            {
                description += newline + "Super Speed";
            }
            if (heroes[lbNames.SelectedIndex].Powers[1])
            {
                description += newline + "Teleportation";
            }
            if (heroes[lbNames.SelectedIndex].Powers[2])
            {
                description += newline + "Mind Control";
            }
            if (heroes[lbNames.SelectedIndex].Powers[3])
            {
                description += newline + "Talking to Animals";
            }
            if (heroes[lbNames.SelectedIndex].Powers[4])
            {
                description += newline + "Projection";
            }
            if (heroes[lbNames.SelectedIndex].Powers[5])
            {
                description += newline + "Emotion Control";
            }
            if (heroes[lbNames.SelectedIndex].Powers[6])
            {
                description += newline + "Super Strength";
            }
            if (heroes[lbNames.SelectedIndex].Powers[7])
            {
                description += newline + "Heightened Senses";
            }
            if (heroes[lbNames.SelectedIndex].Powers[8])
            {
                description += newline + "Quick Reflexes";
            }
            if (heroes[lbNames.SelectedIndex].Powers[9])
            {
                description += newline + "Laser Eyes";
            }
            if (heroes[lbNames.SelectedIndex].Powers[10])
            {
                description += newline + "Flight";
            }
            if (heroes[lbNames.SelectedIndex].Powers[11])
            {
                description += newline + "Element Control";
            }
            if (heroes[lbNames.SelectedIndex].Powers[12])
            {
                description += newline + "Memory";
            }
            if (heroes[lbNames.SelectedIndex].Powers[13])
            {
                description += newline + "Super Smarts";
            }
            description += newline + "Attack:" + newline + heroes[lbNames.SelectedIndex].AttackVal;
            description += newline + "Defense:" + newline + heroes[lbNames.SelectedIndex].DefenseVal;
            description += newline + "Health:" + newline + heroes[lbNames.SelectedIndex].HealthVal;
            description += newline + "Likelihood of Being Swayed to the Dark Side: " + newline + heroes[lbNames.SelectedIndex].DarkSidePropensity;
            description += newline + "Date Abilities Gained: " + newline + heroes[lbNames.SelectedIndex].PowerDate;
            description += newline + "Abilites Gained By: " + newline + heroes[lbNames.SelectedIndex].PowersGainedBy;
            description += newline + "Backstory: " + newline + heroes[lbNames.SelectedIndex].Description;
            tbHeroDescription.Text = description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        public Hero hero;
        public List<Hero> heroes = new List<Hero>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tbDarkSide_Scroll(object sender, EventArgs e)
        {
            lblDarkSideValue.Text = tbDarkSide.Value + "";
        }

        private void btnMakeHero_Click(object sender, EventArgs e)
        {
            hero = new Hero(new List<bool> { cbSuperSpeed.Checked, cbTeleportation.Checked, cbMindControl.Checked, cbTalkingToAnimals.Checked, cbProjection.Checked, cbEmotionControl.Checked, cbSuperStrength.Checked, cbHeightenedSenses.Checked, cbQuickReflexes.Checked, cbLaserEyes.Checked, cbFlight.Checked, cbElementControl.Checked, cbMemory.Checked, cbSuperSmarts.Checked, rbTimeControl.Checked, rbRealityWarping.Checked, rbImmunity.Checked },
                            tbBackstory.Text, txtHeroName.Text, dtAbilitiesGained.Value.ToString(), tbDarkSide.Value, cbAbilitiesGainedBy.Items[cbAbilitiesGainedBy.SelectedIndex].ToString(), hbAttack.Value, hbDefense.Value, hbHealth.Value*10);
            heroes.Add(hero);
            ClearForm();
        }

        public void ClearForm()
        {
            cbSuperSpeed.Checked = false;
            cbTeleportation.Checked = false;
            cbMindControl.Checked = false;
            cbTalkingToAnimals.Checked = false;
            cbProjection.Checked = false;
            cbEmotionControl.Checked = false;
            cbSuperStrength.Checked = false;
            cbHeightenedSenses.Checked = false;
            cbQuickReflexes.Checked = false;
            cbLaserEyes.Checked = false;
            cbFlight.Checked = false;
            cbElementControl.Checked = false;
            cbMemory.Checked = false;
            cbSuperSmarts.Checked = false;
            rbTimeControl.Checked = false;
            rbRealityWarping.Checked = false;
            rbImmunity.Checked = false;
            tbDarkSide.Value = 1;
            tbBackstory.Text = "";
            txtHeroName.Text = "";
            cbAbilitiesGainedBy.SelectedIndex = 0;
            dtAbilitiesGained.Value = new DateTime(2020, 11, 1);
            hbAttack.Value = 0;
            hbDefense.Value = 0;
            hbHealth.Value = 0;
            lblSuccess.Text = "Hero Created! Keep creating heroes \nor reveal the heroes you've made!";
        }

        private void hbAttack_Scroll(object sender, ScrollEventArgs e)
        {
            if (hbAttack.Value + hbDefense.Value + hbHealth.Value > 100 && hbAttack.Value > 0)
            {
                hbAttack.Value -= 1;
            }
            else
            {
                lblAttackVal.Text = hbAttack.Value + "";
            }
        }

        private void hbDefense_Scroll(object sender, ScrollEventArgs e)
        {
            if (hbAttack.Value + hbDefense.Value + hbHealth.Value > 100 && hbDefense.Value > 0)
            {
                hbDefense.Value -= 1;
            }
            else
            {
                lblDefenseVal.Text = hbDefense.Value + "";
            }
        }

        private void hbHealth_Scroll(object sender, ScrollEventArgs e)
        {
            if (hbAttack.Value + hbDefense.Value + hbHealth.Value > 100 && hbHealth.Value > 0)
            {
                hbHealth.Value -= 1;
            }
            else
            {
                lblHealthVal.Text = hbHealth.Value*10 + "";
            }
        }

        private void btnSeeHeroes_Click(object sender, EventArgs e)
        {
            HeroList heroList = new HeroList(heroes);
            heroList.ShowDialog();
        }
    }
}

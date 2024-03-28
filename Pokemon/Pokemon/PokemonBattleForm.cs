using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class PokemonBattleForm : Form
    {

        int userHp = MainForm.userPokemon.Hp, compHp = MainForm.compPokemon.Hp;
        int userEnergy = 0;
        public PokemonBattleForm()
        {
            InitializeComponent();
            this.Size = new Size(2532, 1469);
        }

        private void PokemonBattleForm_Load(object sender, EventArgs e)
        {
            FillProgressBars();
            UpdateHpBars();
            labelInstructions.Text = "FIGHT!!!";
            labelUserDesition.Text = "Choose an Attack";
            labelCompAtkDesition.Text = "Waiting for Comp to choose an attack....";
            SetUpPokemon();
        }

        private void SetUpPokemon()
        {
            labelUserPkm.Text = MainForm.userPokemon.Name;
            labelUserType.Text = MainForm.userPokemon.type;
            labelUserHp.Text = userHp.ToString();
            buttonUserBasicAtk.Text = MainForm.userPokemon.basicAtk;
            buttonUserUltraAtk.Text = MainForm.userPokemon.UltraAtkName;
            labelUserEnergy.Text = userEnergy.ToString();
            buttonUserUltraAtk.Enabled = false;
            labelCompPkm.Text = MainForm.compPokemon.Name;
            labelCompType.Text = MainForm.compPokemon.type;
            labelCompHp.Text = compHp.ToString();
            labelCompBasicAtk.Text = MainForm.compPokemon.basicAtk;
            labelCompUltraAtk.Text = MainForm.compPokemon.UltraAtkName;
            pictureBoxCompPkm.BackgroundImage = ImageLoader.GetPokemonImage(MainForm.compPokemon.Name);
            pictureBoxUserPkm.BackgroundImage = ImageLoader.GetPokemonImage(MainForm.userPokemon.Name);

        }


        private async void buttonUserBasicAtk_Click(object sender, EventArgs e)
        {
            labelInstructions.Text = "Waiting for comp desition";
            buttonUserBasicAtk.Enabled = false;
            labelUserDesition.Text = "Waiting for comp desition";
            labelCompAtkDesition.Text = "Choosing an Attack....";
            await Task.Delay(2000);
            labelInstructions.Text = "Attack!";
            buttonUserBasicAtk.Enabled = true;
            basicAtk();
            userEnergy++;
            labelUserEnergy.Text = userEnergy.ToString();
            if (userEnergy >= 2)
            {
                buttonUserUltraAtk.Enabled = true;
            }
            winCondition();
        }

        private async void buttonUserUltraAtk_ClickAsync(object sender, EventArgs e)
        {
            labelInstructions.Text = "Waiting for comp desition";
            buttonUserBasicAtk.Enabled = false;
            labelUserDesition.Text = "Waiting for comp desition";
            labelCompAtkDesition.Text = "Choosing an Attack....";
            await Task.Delay(2000);
            labelInstructions.Text = "Attack!";
            buttonUserBasicAtk.Enabled = true;

            ultraAtk();
            userEnergy -= 2;
            labelUserEnergy.Text = userEnergy.ToString();
            if (userEnergy < 2)
            {
                buttonUserUltraAtk.Enabled = false;
            }
            winCondition();
        }

        private void ultraAtk()
        {
            Random whoAttaks = new Random();
            labelUserDesition.Text = "Waiting for comp desition";
            int whoAttack = whoAttaks.Next(2);
            labelUserDesition.Text = MainForm.userPokemon.useBasicAtk();
            if (whoAttack == 0)
            {
                labelInstructions.Text = "User`s " + MainForm.userPokemon.Name + " Attacks!";
                labelUserDesition.Text = MainForm.userPokemon.useUltraAtk();
                labelCompAtkDesition.Text = "Comp`s" + MainForm.compPokemon.Name + " used an attack and missed!";
                UserDamageCalc(1);
            }
            else if (whoAttack == 1)
            {
                compAttack();
            }
        }

        private void UserDamageCalc(int UltraOrBasic)
        {
            if (((MainForm.compPokemon.type == "Fire" && MainForm.userPokemon.type == "Water")
                || (MainForm.compPokemon.type == "Water" && MainForm.userPokemon.type == "Grass")
                || (MainForm.compPokemon.type == "Grass" && MainForm.userPokemon.type == "Fire"))
                && UltraOrBasic == 0)
            {
                compHp -= (MainForm.userPokemon.basicDmg + 10);
            }
            else if (UltraOrBasic == 1)
            {
                if (MainForm.compPokemon.type == "Fire" && MainForm.userPokemon.type == "Water")
                {
                    WaterAtk atk = (WaterAtk)Enum.Parse(typeof(WaterAtk), MainForm.userPokemon.UltraAtkName);
                    compHp -= ((int)atk + 25);
                }
                else if (MainForm.compPokemon.type == "Water" && MainForm.userPokemon.type == "Grass")
                {
                    GrassAtk atk = (GrassAtk)Enum.Parse(typeof(GrassAtk), MainForm.userPokemon.UltraAtkName);
                    compHp -= (int)atk + 20;
                    userHp += 20;
                }
                else if (MainForm.compPokemon.type == "Grass" && MainForm.userPokemon.type == "Fire")
                {
                    FireAtk atk = (FireAtk)Enum.Parse(typeof(FireAtk), MainForm.userPokemon.UltraAtkName);
                    compHp -= ((int)atk + 30);
                    userHp -= 20;
                }
                else if (MainForm.userPokemon.type == "Fire")
                {
                    FireAtk atk = (FireAtk)Enum.Parse(typeof(FireAtk), MainForm.userPokemon.UltraAtkName);
                    compHp -= (int)atk;
                    userHp -= 20;
                }
                else if (MainForm.userPokemon.type == "Water")
                {
                    WaterAtk atk = (WaterAtk)Enum.Parse(typeof(WaterAtk), MainForm.userPokemon.UltraAtkName);
                    compHp -= (int)atk;
                }
                else if (MainForm.userPokemon.type == "Grass")
                {
                    GrassAtk atk = (GrassAtk)Enum.Parse(typeof(GrassAtk), MainForm.userPokemon.UltraAtkName);
                    compHp -= (int)atk;
                    userHp += 20;
                }
            }
            else if (UltraOrBasic == 0)
            {
                compHp -= MainForm.userPokemon.basicDmg;
            }

            labelCompHp.Text = compHp.ToString();
            labelUserHp.Text = userHp.ToString();
            UpdateHpBars();

        }

        private void CompDamageCalc(int ultraOrBasic)
        {
            if (((MainForm.userPokemon.type == "Fire" && MainForm.compPokemon.type == "Water")
                 || (MainForm.userPokemon.type == "Water" && MainForm.compPokemon.type == "Grass")
                 || (MainForm.userPokemon.type == "Grass" && MainForm.compPokemon.type == "Fire"))
                    && ultraOrBasic == 0)
            {
                userHp -= (MainForm.compPokemon.basicDmg + 10);
            }
            else if (ultraOrBasic == 1)
            {
                if (MainForm.userPokemon.type == "Fire" && MainForm.compPokemon.type == "Water")
                {
                    WaterAtk atk = (WaterAtk)Enum.Parse(typeof(WaterAtk), MainForm.compPokemon.UltraAtkName);
                    userHp -= ((int)atk + 25);
                }
                else if (MainForm.userPokemon.type == "Water" && MainForm.compPokemon.type == "Grass")
                {
                    GrassAtk atk = (GrassAtk)Enum.Parse(typeof(GrassAtk), MainForm.compPokemon.UltraAtkName);
                    userHp -= (int)atk + 25;
                    compHp += 20;
                }
                if (MainForm.userPokemon.type == "Grass" && MainForm.compPokemon.type == "Fire")
                {
                    FireAtk atk = (FireAtk)Enum.Parse(typeof(FireAtk), MainForm.compPokemon.UltraAtkName);
                    userHp -= ((int)atk + 25);
                    compHp -= 20;
                }
                else if (MainForm.compPokemon.type == "Fire")
                {
                    FireAtk atk = (FireAtk)Enum.Parse(typeof(FireAtk), MainForm.compPokemon.UltraAtkName);
                    userHp -= (int)atk;
                    compHp -= 20;
                }
                else if (MainForm.compPokemon.type == "Water")
                {
                    WaterAtk atk = (WaterAtk)Enum.Parse(typeof(WaterAtk), MainForm.compPokemon.UltraAtkName);
                    userHp -= (int)atk;
                }
                else if (MainForm.compPokemon.type == "Grass")
                {
                    GrassAtk atk = (GrassAtk)Enum.Parse(typeof(GrassAtk), MainForm.compPokemon.UltraAtkName);
                    userHp -= (int)atk;
                    compHp += 20;
                }
            }
            else if (ultraOrBasic == 0)
            {
                userHp -= MainForm.compPokemon.basicDmg;
            }

            labelCompHp.Text = compHp.ToString();
            labelUserHp.Text = userHp.ToString();
            UpdateHpBars();

        }

        private void basicAtk()
        {
            Random whoAttaks = new Random();
            int whoAttack = whoAttaks.Next(2);
            labelUserDesition.Text = MainForm.userPokemon.useBasicAtk();
            if (whoAttack == 0)
            {
                labelInstructions.Text = "User`s " + MainForm.userPokemon.Name + " Attacks!";
                labelUserDesition.Text = MainForm.userPokemon.useBasicAtk();
                labelCompAtkDesition.Text = "Comp`s " + MainForm.compPokemon.Name + " used an attack and missed!";
                UserDamageCalc(0);
            }
            else if (whoAttack == 1)
            {
                compAttack();
            }
        }

        private void compAttack()
        {
            Random random = new Random();
            int randomDesition = random.Next(2);
            labelInstructions.Text = "Comp`s " + MainForm.compPokemon.Name + " Attacks!";
            labelUserDesition.Text = "User`s " + MainForm.userPokemon.Name + " used an attack and missed!";
            if (randomDesition == 0)
            {
                labelCompAtkDesition.Text = MainForm.compPokemon.useBasicAtk();
                CompDamageCalc(0);
            }
            else if (randomDesition == 1)
            {
                labelCompAtkDesition.Text = MainForm.compPokemon.useUltraAtk();
                CompDamageCalc(1);
            }
        }

        private void winCondition()
        {
            if (userHp <= 0 || compHp <= 0)
            {
                if (userHp <= 0)
                {
                    MessageBox.Show("You Lost,Better luck next time");
                }
                else if (compHp <= 0)
                {
                    MainForm.allPkm.FirstOrDefault(pokemon => pokemon.Name == MainForm.userPokemon.Name).Level += 1;
                    MainForm.allPkm.FirstOrDefault(pokemon => pokemon.Name == MainForm.userPokemon.Name).Hp += 20;
                    MessageBox.Show("Congrats!you win! your pokemon gained 1 level");
                }
                MainForm newForm = new MainForm();
                this.Hide();
                newForm.Show();
            }
            else return;

        }

        private void FillProgressBars()
        {
            progressBarUserHp.Maximum = userHp;
            progressBarCompHp.Maximum = compHp;

        }
        private void UpdateHpBars()
        {
            if (compHp <= 0 || userHp <= 0)
            {
                if (compHp <= 0)
                {
                    progressBarCompHp.Value = 0;
                }
                if (userHp <= 0)
                {
                    progressBarUserHp.Value = 0;
                }
            }
            else if (userHp > progressBarUserHp.Maximum || compHp > progressBarCompHp.Maximum)
            {
                if (userHp > progressBarUserHp.Maximum)
                {
                    progressBarUserHp.Maximum = userHp;
                    progressBarUserHp.Value = userHp;
                }
                if (compHp > progressBarCompHp.Maximum)
                {
                    progressBarCompHp.Maximum = compHp;
                    progressBarCompHp.Value = compHp;
                }
            }
            else
            {
                progressBarCompHp.Value = compHp;
                progressBarUserHp.Value = userHp;
            }



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel the battle?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                MainForm newForm = new MainForm();
                this.Hide();
                newForm.Show();
            }
            else return;



        }
    }
}



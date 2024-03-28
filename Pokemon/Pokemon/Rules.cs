using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            this.Size = new Size(1597, 1522);
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            labelRules.Text = "Playing this game is very easy!\n" +
                "You can choose any pokemon you like or even create a new pokemon of your own\n\n" +
                "1.After picking a pokemon press Start Battle,and the battle will begin!\n\n" +
                "2.Your oponent is your own computer,we call it Comp,it will choose a pokemon in random\n\n" +
                "3.evey turn you can pick an attack, you have your basic attack,and your ultra attack.\n\n" +
                "4.The ulra attack can be used only if you have 2 energy or more\n" +
                "to gain energy you need to use your basic attack.every attack will gain 1 energy\n\n" +
                "5.Comp will choose an attack in random in can be a basic attack or an ultra attack so be prepared!\n\n" +
                "6.the winner is the player that reduced the opponents health to 0\n\n" +
                "7.Every time you win your pokemon will gain 1 level and with that 20 more HP\n\n" +
                "8.You can save your progress simply by clicking Save Game in the main menu\n\n" +
                "9.Every turn you pick and attack you have 50% chance to hit the enemy.\n" +
                "if you hit the enemy then you wll not recive any dammage,but beware,the enemy has the same chance as well!\n\n" +
                "10.There are 3 types of Pokemon, grass,fire and water. each type has its own advantages\n\n" +
                "grass is strong agains water,water is strong agains fire,and fire agains grass\n" +
                "if you hit a pokemon with weakness you deal 20 more damage in every hit\n" +
                "11.Grass types have weaker attacks but they heal themselves every time they hit the enemy\n\n" +
                "Fire types are naturally stronger but they deal damage to themselves every time they use ultra attack\n" +
                "Water types are natural,the deal decent dammage and dont hit themselvs.\n\n" +
                "GOOD LUCK AND HAVE FUN! ";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            this.Hide();
            newForm.Show();
        }

        private void labelRules_Click(object sender, EventArgs e)
        {

        }
    }
}

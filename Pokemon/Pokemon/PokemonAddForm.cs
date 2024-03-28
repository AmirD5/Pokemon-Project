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
    public partial class PokemonAddForm : Form
    {
        public PokemonAddForm()
        {
            InitializeComponent();
            this.Size = new Size(1308, 1140);
        }

        private void PokemonAddForm_Load(object sender, EventArgs e)
        {
            populateComboAtks();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxType.Text != "" && textBoxName.Text != "")
            {
                string type = comboBoxType.SelectedItem.ToString();
                string name = textBoxName.Text;
                int hp = (int)numericUpDownHp.Value;
                string selectedAtk = ((DataRowView)comboBoxAtks.SelectedItem)["Attack"].ToString();
                CreatePokemon(type, name, hp, selectedAtk);
                MessageBox.Show("New " + type + " type pokemon " + name + " was created");
                this.Hide();
                MainForm form = new MainForm();
                form.Show();
            }
            else if (comboBoxType.Text == "")
            {
                MessageBox.Show("Please Select A Type!", "No Type!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxName.Text == "")
            {
                MessageBox.Show("Please Come up with a name!", "No Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateComboAtks();
        }

        private void populateComboAtks()
        {
            DataTable AtkTable = new DataTable();
            AtkTable.Columns.Add("Type", typeof(string));  // Added a column for attack type
            AtkTable.Columns.Add("Attack", typeof(string));

            comboBoxAtks.DataSource = AtkTable;
            comboBoxAtks.DisplayMember = "Attack";  // Set the DisplayMember property

            if (comboBoxType.SelectedItem != null)
            {
                string selectedType = comboBoxType.SelectedItem.ToString();

                if (selectedType == "Fire")
                {
                    foreach (FireAtk fireAtk in Enum.GetValues(typeof(FireAtk)))
                    {
                        AtkTable.Rows.Add("FireAtk", fireAtk.ToString());
                    }
                }
                else if (selectedType == "Water")
                {
                    foreach (WaterAtk waterAtk in Enum.GetValues(typeof(WaterAtk)))
                    {
                        AtkTable.Rows.Add("WaterAtk", waterAtk.ToString());
                    }
                }
                else if (selectedType == "Grass")
                {
                    foreach (GrassAtk grassAtk in Enum.GetValues(typeof(GrassAtk)))
                    {
                        AtkTable.Rows.Add("GrassAtk", grassAtk.ToString());
                    }
                }
            }

        }

        private void CreatePokemon(string type, string name, int hp, string selectedAtk)
        {
            if (type == "Fire")
            {
                FireAtk fire = (FireAtk)Enum.Parse(typeof(FireAtk), selectedAtk);
                Pokemon newPkm = new FireType(name, hp, fire);
                MainForm.allPkm.Add(newPkm);
            }
            if (type == "Water")
            {
                WaterAtk water = (WaterAtk)Enum.Parse(typeof(WaterAtk), selectedAtk);
                Pokemon newPkm = new WaterType(name, hp, water);
                MainForm.allPkm.Add(newPkm);

            }
            if (type == "Grass")
            {
                GrassAtk grass = (GrassAtk)Enum.Parse(typeof(GrassAtk), selectedAtk);
                Pokemon newPkm = new GrassType(name, hp, grass);
                MainForm.allPkm.Add(newPkm);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void comboBoxAtks_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

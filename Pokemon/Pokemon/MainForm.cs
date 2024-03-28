using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Pokemon
{
    public partial class MainForm : Form
    {

        public static List<Pokemon> allPkm = new List<Pokemon> //creating default pokemon so the user will have some options
        {
            new FireType("Charizard", 490, FireAtk.BlastBurn),
            new FireType("Ninetales", 500,FireAtk.FlameCharge),
            new FireType("Arcanine", 480,FireAtk.FlameThrower),
            new FireType("Entei", 470, FireAtk.FireBast),
            new WaterType("Blastoise", 480, WaterAtk.HydroCannon),
            new WaterType("Starmie", 490,WaterAtk.BubbleBeam),
            new WaterType("Gyarados", 470,WaterAtk.HydroPump),
            new WaterType("Suicune",500,WaterAtk.Surf),
            new GrassType("Venusaur", 470, GrassAtk.FrenzyPlant),
            new GrassType("Victreebel", 480, GrassAtk.GigaDrain),
            new GrassType("Vileplume", 470, GrassAtk.PetalDance),
            new GrassType("Celebi", 500, GrassAtk.SeedBomb)
        };
        public static Pokemon userPokemon;
        public static Pokemon compPokemon;


        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(1982, 1343);
            ImageLoader.loadImages();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxTypes();
        }


        private void PopulateComboBoxTypes()
        {
            var uniqueTypes = allPkm.Select(pokemon => pokemon.type).Distinct().ToList();
            comboBoxType.DataSource = uniqueTypes;
        }

        private void PopulateComboBoxNames(List<Pokemon> pokemons)
        {
            DataTable nameTable = new DataTable();
            nameTable.Columns.Add("Name", typeof(string));
            foreach (var pokemon in pokemons)
            {
                nameTable.Rows.Add(pokemon.Name);
            }

            comboBoxName.DataSource = nameTable;
            comboBoxName.DisplayMember = "Name";
        }


        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxType.SelectedItem.ToString();
            var pokemonsOfType = allPkm.Where(pokemon => pokemon.type == selectedType).ToList();

            PopulateComboBoxNames(pokemonsOfType);
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboBoxName.Text;
            Pokemon selectedPkm = allPkm.FirstOrDefault(pokemon => pokemon.Name == selectedName);
            if (selectedPkm != null)
            {
                labelHP.Text = selectedPkm.Hp.ToString();
                pictureBoxPokemonImage.BackgroundImage = ImageLoader.GetPokemonImage(selectedPkm.Name);
                labelWeakTo.Text = selectedPkm.weakTo;
                labelMainAtk.Text = "Basic: " + selectedPkm.basicAtk;
                labelUltraAtk.Text = "Ultra: " + selectedPkm.UltraAtkName;
                labelLvl.Text = selectedPkm.Level.ToString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string pokemonName = comboBoxName.Text;
            DialogResult dr = MessageBox.Show("Are you sure you want to delete " + pokemonName + "?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string selectedName = comboBoxName.Text;
                Pokemon selectedPkm = allPkm.FirstOrDefault(pokemon => pokemon.Name == selectedName);
                if (selectedPkm != null)
                {
                    allPkm.Remove(selectedPkm);
                    PopulateComboBoxNames(allPkm);
                    MessageBox.Show(pokemonName + " was removed from lists", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }



        }

        private void buttonAddPokemonToList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokemonAddForm newPkm = new PokemonAddForm();
            newPkm.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }



        public void SaveData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, allPkm);
                }

                MessageBox.Show("Data saved successfully!");
            }
        }

        public void LoadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        MainForm.allPkm = (List<Pokemon>)formatter.Deserialize(fileStream);
                    }

                    MessageBox.Show("Data loaded successfully!");
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to start the battle?", "Battle start", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                string name = comboBoxName.Text;
                userPokemon = allPkm.FirstOrDefault(pokemon => pokemon.Name == name);
                compPokemon = chooseRandomPokemon();
                PokemonBattleForm newBattle = new PokemonBattleForm();
                this.Hide();
                newBattle.Show();
            }

        }

        private Pokemon chooseRandomPokemon()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, allPkm.Count);
            return allPkm[randomIndex];
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit the game?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;

        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            Rules newForm = new Rules();
            this.Hide();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

    }
}




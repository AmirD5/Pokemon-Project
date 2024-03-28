using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pokemon
{
    [Serializable]
    public abstract class Pokemon
    {
        public string Name { get; set; }
        public int Level = 1;
        private int hp;
 

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }

        public string type { get; set; }
        public string weakTo { get; set; }
        public string basicAtk { get; set; }

        public int basicDmg { get; set; }

        public string UltraAtkName { get; set; }

        public abstract string useBasicAtk();
        public abstract string useUltraAtk();


    }
/*    public static void loadImages()
    {
        pokemonImages["Charizard"] = Image.FromFile(Path.Combine(imagesFoler, "Charizard.png");
        pokemonImages["Ninetales"] = Image.FromFile("C:/Users/User/Desktop/Project/MyProject/Pokemon/Pokemon/PokemonPics/Nintetales.png");
        pokemonImages["Arcanine"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Arcanine.png");
        pokemonImages["Entei"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Entei.png");
        pokemonImages["Blastoise"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Blastoise.png");
        pokemonImages["Starmie"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Starmie.png");
        pokemonImages["Gyarados"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Gyarados.png");
        pokemonImages["Suicune"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Suicune.png");
        pokemonImages["Venusaur"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Venusaur.png");
        pokemonImages["Victreebel"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Victreebel.png");
        pokemonImages["Vileplume"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Vileplume.png");
        pokemonImages["Celebi"] = Image.FromFile("C:\\Users\\User\\Desktop\\Project\\MyProject\\Pokemon\\Pokemon\\PokemonPics\\Celebi.png");
    }*/



}


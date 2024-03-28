using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Pokemon
{
    public class ImageLoader
    {
        public static string imagesFolder = Path.Combine(Application.StartupPath, "PokemonPics");
        private static Dictionary<string, Image> pokemonImages = new Dictionary<string, Image>();

        public static void loadImages()
        {
            pokemonImages["Charizard"] = Image.FromFile(Path.Combine(imagesFolder, "Charizard.png"));
            pokemonImages["Ninetales"] = Image.FromFile(Path.Combine(imagesFolder, "Ninetales.png"));
            pokemonImages["Arcanine"] = Image.FromFile(Path.Combine(imagesFolder, "Arcanine.png"));
            pokemonImages["Entei"] = Image.FromFile(Path.Combine(imagesFolder, "Entei.png"));
            pokemonImages["Blastoise"] = Image.FromFile(Path.Combine(imagesFolder, "Blastoise.png"));
            pokemonImages["Starmie"] = Image.FromFile(Path.Combine(imagesFolder, "Starmie.png"));
            pokemonImages["Gyarados"] = Image.FromFile(Path.Combine(imagesFolder, "Gyarados.png"));
            pokemonImages["Suicune"] = Image.FromFile(Path.Combine(imagesFolder, "Suicune.png"));
            pokemonImages["Venusaur"] = Image.FromFile(Path.Combine(imagesFolder, "Venusaur.png"));
            pokemonImages["Victreebel"] = Image.FromFile(Path.Combine(imagesFolder, "Victreebel.png"));
            pokemonImages["Vileplume"] = Image.FromFile(Path.Combine(imagesFolder, "Vileplume.png"));
            pokemonImages["Celebi"] = Image.FromFile(Path.Combine(imagesFolder, "Celebi.png"));
        }

        public static Image GetPokemonImage(string name)
        {
            if (pokemonImages.ContainsKey(name))
            {
                return pokemonImages[name];
            }
            return null;
        }
    }
}

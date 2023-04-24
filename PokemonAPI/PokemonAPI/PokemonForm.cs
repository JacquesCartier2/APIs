using PokeAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonAPI
{
    public partial class PokemonForm : Form
    {
        PokemonSpecies species;
        string defaultText = "*";

        public PokemonForm()
        {
            InitializeComponent();
        }

        private void Pokemon_Load(object sender, EventArgs e)
        {

        }

        //get a pokemon from the API based on user input. Users may input a name or ID. 
        private async void btn_Pokemon_Click(object sender, EventArgs e)
        {
            string input = txb_Pokemon.Text;

            await GetSpeciesAsync(input);

            ShowSpeciesInfo();
        }

        //return a pokemon based on name or ID.
        async Task GetSpeciesAsync(string _input)
        {
            bool usingID = false;
            int ID = 0;

            //if the input can be parsed use it as an ID.
            try
            {
                ID = int.Parse(_input);
                usingID = true;
            }
            catch
            {

            }

            //set the species variable using the API and either ID or _input.
            if (usingID)
            {
                try
                {
                    species = await DataFetcher.GetApiObject<PokemonSpecies>(ID);
                }
                catch
                {
                    MessageBox.Show(ID + " is not a valid ID.");
                    return;
                }
                
            }
            else
            {
                try
                {
                    species = await DataFetcher.GetNamedApiObject<PokemonSpecies>(_input);
                }
                catch
                {
                    MessageBox.Show(_input + " is not a valid name.");
                    return;
                }
            }
        }

        //show the information of the species on the form. Any unavailable fields will show the default text.
        void ShowSpeciesInfo()
        {
            try
            {
                txt_Name.Text = species.Name;
            }
            catch
            {
                txt_Name.Text = defaultText;
            }

            try
            {
                txt_Happiness.Text = species.BaseHappiness.ToString();
            }
            catch
            {
                txt_Happiness.Text = defaultText;
            }

            try
            {
                txt_Capture.Text = species.CaptureRate.ToString();
            }
            catch
            {
                txt_Capture.Text = defaultText;
            }

            try
            {
                txt_Habitat.Text = species.Habitat.Name;
            }
            catch
            {
                txt_Habitat.Text = defaultText;
            }

            try
            {
                txt_Growth.Text = species.GrowthRate.Name;
            }
            catch
            {
                txt_Growth.Text = defaultText;
            }

            try
            {
                txt_Flavor.Text = species.FlavorTexts[0].FlavorText;
            }
            catch
            {
                txt_Flavor.Text = defaultText;
            }

            try
            {
                txt_Egg.Text = species.EggGroups[0].Name; ;
            }
            catch
            {
                txt_Egg.Text = defaultText;
            }
        }
    }
}

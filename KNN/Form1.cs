using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.Drawing;

namespace KNN
{
    public partial class Form1 : Form
    {
        List<Rating> ratings;
        public Form1()
        {
            InitializeComponent();

            komentarai();
            Text = "Geriausi filmai";

            // Read json file. Path: KNN/bin/Debug
            ratings = JsonConvert.DeserializeObject<List<Rating>>(File.ReadAllText("movies.json"));
        }

        private List<Rating> FindKNearestNeighbours(Rating newRating, List<Rating> ratings, int k)
        {
            foreach (var rating in ratings)
            {
                rating.Distance = Utils.EuclideanDistance(newRating, rating);
            }

            ratings = ratings.OrderByDescending(r => r.Distance).ToList();

            return ratings.GetRange(0, k);
        }

        private float[] CalculateRatingsForNotSeenMovies(Rating newRating, List<Rating> nearestRatings)
        {
            float[] ratingAvgs = new float[9];

            foreach (var rating in nearestRatings)
            {
                if (newRating.Episode1 == -1f)
                    ratingAvgs[0] += rating.Episode1;

                if (newRating.Episode2 == -1f)
                    ratingAvgs[1] += rating.Episode2;

                if (newRating.Episode3 == -1f)
                    ratingAvgs[2] += rating.Episode3;

                if (newRating.Episode4 == -1f)
                    ratingAvgs[3] += rating.Episode4;

                if (newRating.Episode5 == -1f)
                    ratingAvgs[4] += rating.Episode5;

                if (newRating.Episode6 == -1f)
                    ratingAvgs[5] += rating.Episode6;

                if (newRating.Episode7 == -1f)
                    ratingAvgs[6] += rating.Episode7;

                if (newRating.Rogue1 == -1f)
                    ratingAvgs[7] += rating.Rogue1;

                if (newRating.Holiday == -1f)
                    ratingAvgs[8] += rating.Holiday;
            }

            for (int i = 0; i < ratingAvgs.Length; i++)
            {
                if (ratingAvgs[i] != 0)
                    ratingAvgs[i] /= nearestRatings.Count;
            }

            return ratingAvgs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                MessageBox.Show("Patikrinkite ar užpildėte visus laukus");
                return;
            }

            var rating = GenerateNewRating();

            var kRatings = FindKNearestNeighbours(rating, ratings, 5);

            float[] recomendationScore = CalculateRatingsForNotSeenMovies(rating, kRatings);

            DisplayResults(recomendationScore);
        }

        private bool IsInputValid()
        {
            if (comboBox1.Text == "" || 
                comboBox2.Text == "" || 
                comboBox3.Text == "" || 
                comboBox4.Text == "" || 
                comboBox5.Text == "" || 
                comboBox6.Text == "" || 
                comboBox7.Text == "" || 
                comboBox8.Text == "" ||
                comboBox9.Text == "")
            {
                return false;
            }

            if (comboBox1.Text == "Nemačiau" &&
                comboBox2.Text == "Nemačiau" &&
                comboBox3.Text == "Nemačiau" &&
                comboBox4.Text == "Nemačiau" &&
                comboBox5.Text == "Nemačiau" &&
                comboBox6.Text == "Nemačiau" &&
                comboBox7.Text == "Nemačiau" &&
                comboBox8.Text == "Nemačiau" &&
                comboBox9.Text == "Nemačiau")
            {
                return false;
            }

            return true;
        }

        private Rating GenerateNewRating()
        {
            float ep1 = comboBox1.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox1.Text);
            float ep2 = comboBox2.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox2.Text);
            float ep3 = comboBox3.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox3.Text);
            float ep4 = comboBox4.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox4.Text);
            float ep5 = comboBox5.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox5.Text);
            float ep6 = comboBox6.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox6.Text);
            float ep7 = comboBox7.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox7.Text);
            float rogue1 = comboBox8.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox8.Text);
            float holiday = comboBox9.Text == "Nemačiau" ? (float)Convert.ToDouble(-1) : (float)Convert.ToDouble(comboBox9.Text);

            return new Rating("", ep1, ep2, ep3, ep4, ep5, ep6, ep7, rogue1, holiday);
        }

        private void DisplayResults(float[] recomendationScore)
        {
            List<Tuple<string, float>> output = new List<Tuple<string, float>>()
            {
                new Tuple<string, float>("Žvaigždžių karai: epizodas I - pavojaus šešėlis", recomendationScore[0]),
                new Tuple<string, float>("Žvaigždžių karai: epizodas II - klonų ataka", recomendationScore[1]),
                new Tuple<string, float>("Žvaigždžių karai: epizodas III - sitų kerštas", recomendationScore[2]),
                new Tuple<string, float>("Žvaigždžių karai: epizodas IV - nauja viltis", recomendationScore[3]),
                new Tuple<string, float>("Žvaigždžių karai: epizodas V - Imperija kontratakuoja", recomendationScore[4]),
                new Tuple<string, float>("Žvaigždžių karai: epizodas VI - džedajaus sugrįžimas", recomendationScore[5]),
                new Tuple<string, float>("Žvaigždžių karai: epizodas VII - galia nubunda", recomendationScore[6]),
                new Tuple<string, float>("Šelmis-1. Žvaigždžių karų istorija", recomendationScore[7]),
                new Tuple<string, float>("Solo. Žvaigždžių karų istorija", recomendationScore[8]),
            };

            output = output.OrderByDescending(score => score.Item2).ToList();

            panel1.Controls.Clear();

            int i = 0;
            foreach (var item in output)
            {
                if (item.Item2 > 0)
                {
                    Label line = new Label
                    {
                        Text = item.Item1 + ": " + item.Item2.ToString(),
                        Location = new Point(10, i * 30),
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                };

                    panel1.Controls.Add(line);
                }
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Programoje pateikti visi žvaigždžių karų filmai, kiekvieną filmą reikia įvertinti vertinimo sistema: \n\n "+
                "'Nemačiau' - Jei filmo nemačiau  \n1 -   \n2 - Nepatiko \n3 - Iš dalies patiko \n4 - Patiko \n5 - Labai patiko "
                +"\n\nAtliktus filmų vertinimą, paspaudus mygtuką 'gauti rekomendacijas' programos algoritmas apskaičiuos nematytų filmų vertinimą, taip galimą bus nustatyti ar filmas patiks ar ne." 
            +"\n\nFilmus vertinkite pagal atsižvelgdami į šiuos kriterijus : \n1. Filmo scenarijų\n2. Filmo pasakojimą\n3. Filmo nagrinėjamus klausimus\n4. Filmo temas\n5. Filmo įprasminamas vertybes",
        
    "INSTRUKCIJA");
            return;

        }

        private void komentarai()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aurim\OneDrive\Stalinis kompiuteris\KNN\KNN\bin\Debug\komentarai.txt");
            int i = 0;
            foreach (var l in lines)
            {
                var s = l.Split('-');
                Label line = new Label
                {
                    Text = s[0]+"     "+s[1]+"\n"+s[2]+"\n"+s[3],
                    Location = new Point(10, i * 90),
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular)

                };
                
                panel2.Controls.Add(line);
                i++;
            }

        }

      

    }
}

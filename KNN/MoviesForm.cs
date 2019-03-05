using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNN
{
    public partial class MoviesForm : Form
    {
        List<Movie> movies; 
        public MoviesForm()
        {
            InitializeComponent();
            movies = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(@"..\..\about.json"));
            SetData(0);
        }

        private void SetData(int id)
        {
            Movie m = movies[id];

            pictureBox1.Image = Image.FromFile($"../../images/{m.Id}.jpg");

            l_title.Text = m.Title;
            l_imdb.Text = "Imdb: " + m.Imdb.ToString();
            l_genre.Text = "Žanras: " + m.Genre;
            l_date.Text = "Premjera: " + m.Date.ToString();
            l_director.Text = "Režisierius: " + m.Director;
            l_duration.Text = "Trukmė: " + m.DurationId;
            l_about.Text = "   " + m.About;

            string actors = "";
            foreach (var actor in m.Actors)
            {
                actors += "* " + actor + "\n\n";
            }

            l_actors.Text = actors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.gg = "kebabas";
            form1.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetData(comboBox1.SelectedIndex);
        }

        private void MoviesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
        }
    }
}

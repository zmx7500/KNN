using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{
    class Movie
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("imdb")]
        public float Imdb { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("date")]
        public int Date { get; private set; }

        [JsonProperty("duration")]
        public string DurationId { get; private set; }

        [JsonProperty("director")]
        public string Director { get; private set; }

        [JsonProperty("genre")]
        public string Genre { get; private set; }

        [JsonProperty("actors")]
        public List<string> Actors { get; private set; }

        [JsonProperty("about")]
        public string About { get; private set; }

        public Movie()
        {
        }

        public Movie(int id, float imdb, string title, int date, string durationId, string director, string genre, List<string> actors, string about)
        {
            Id = id;
            Imdb = imdb;
            Title = title;
            Date = date;
            DurationId = durationId;
            Director = director;
            Genre = genre;
            Actors = actors;
            About = about;
        }
    }
}

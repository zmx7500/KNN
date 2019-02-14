using Newtonsoft.Json;

namespace KNN
{
    class Rating
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("I")]
        public float Episode1 { get; private set; }

        [JsonProperty("II")]
        public float Episode2 { get; private set; }

        [JsonProperty("III")]
        public float Episode3 { get; private set; }

        [JsonProperty("IV")]
        public float Episode4 { get; private set; }

        [JsonProperty("V")]
        public float Episode5 { get; private set; }

        [JsonProperty("VI")]
        public float Episode6 { get; private set; }

        [JsonProperty("VII")]
        public float Episode7 { get; private set; }

        [JsonProperty("Rogue1")]
        public float Rogue1 { get; private set; }

        [JsonProperty("Holiday")]
        public float Holiday { get; private set; }

        public float Distance { get; set; } = -1f;

        public Rating()
        {
        }

        public Rating(string name, float episode1, float episode2, float episode3, float episode4, float episode5,
            float episode6, float episode7, float rogue1, float holiday)
        {
            Name = name;
            Episode1 = episode1;
            Episode2 = episode2;
            Episode3 = episode3;
            Episode4 = episode4;
            Episode5 = episode5;
            Episode6 = episode6;
            Episode7 = episode7;
            Rogue1 = rogue1;
            Holiday = holiday;
        }

        public Rating(string name, float episode1, float episode2, float episode3, float episode4, float episode5, 
            float episode6, float episode7, float rogue1, float holiday, float distance)
        {
            Name = name;
            Episode1 = episode1;
            Episode2 = episode2;
            Episode3 = episode3;
            Episode4 = episode4;
            Episode5 = episode5;
            Episode6 = episode6;
            Episode7 = episode7;
            Rogue1 = rogue1;
            Holiday = holiday;
            Distance = distance;
        }

        
    }


}

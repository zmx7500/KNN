using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{
    class Utils
    {
        public static float EuclideanDistance(Rating newRating, Rating rating)
        {
            float ep1 = 0f, 
                ep2 = 0f, 
                ep3 = 0f, 
                ep4 = 0f, 
                ep5 = 0f, 
                ep6 = 0f, 
                ep7 = 0f, 
                rogue1 = 0f, 
                holiday = 0f;

            if (newRating.Episode1 != -1f)
                ep1 = rating.Episode1 - newRating.Episode1;

            if (newRating.Episode2 != -1f)
                ep2 = rating.Episode2 - newRating.Episode2;

            if (newRating.Episode3 != -1f)
                ep3 = rating.Episode3 - newRating.Episode3;

            if (newRating.Episode4 != -1f)
                ep4 = rating.Episode4 - newRating.Episode4;

            if (newRating.Episode5 != -1f)
                ep5 = rating.Episode5 - newRating.Episode5;

            if (newRating.Episode6 != -1f)
                ep6 = rating.Episode6 - newRating.Episode6;

            if (newRating.Episode7 != -1f)
                ep7 = rating.Episode7 - newRating.Episode7;

            if (newRating.Rogue1 != -1f)
                rogue1 = rating.Rogue1 - newRating.Rogue1;

            if (newRating.Episode2 != -1f)
                holiday = rating.Holiday - newRating.Holiday;

            float distance = (float)Math.Sqrt(
                Math.Pow(ep1, 2) + 
                Math.Pow(ep2, 2) + 
                Math.Pow(ep3, 2) + 
                Math.Pow(ep4, 2) + 
                Math.Pow(ep5, 2) + 
                Math.Pow(ep6, 2) + 
                Math.Pow(ep7, 2) + 
                Math.Pow(rogue1, 2) +
                Math.Pow(holiday, 2));

            return 1f / (1f + distance);
        }
    }
}

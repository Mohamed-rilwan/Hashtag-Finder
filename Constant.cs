using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtagFinder
{
    public class Constant
    {
        public static Tuple<string[], string[], string[], string[], int> Values()
        {
            int percent = 1;
            string[] BirdHashtagArray = { "#bird", "#birdphotography", "#birdsoginstagram", "#birdwatching", "#birdsogprey", "#nature", "#wildlife", "#wanderrex", "#naturephotography", "#wildlifephotography", "#bestbirdshots", "#bird_captures", "#birdplanet", "#birdlife", "#bird_watchers_daily", "#wildlifeplanet" };
            string[] AnimalHashtagArray = { "#animal", "#animalphotography", "#animalsoginstagram", "#animalwatching", "#animalsogprey", "#nature", "#wildlife", "#wanderrex", "#naturephotography", "#wildlifephotography", "#bestanimalshots", "#animal_captures", "#animalplanet", "#animallife", "#animal_watchers_daily", "#wildlifeplanet" };
            string[] TravelHashtagArray = { "#travel", "#travelphotography", "#photography", "#nature", "#travelgram", "#love", "#photooftheday", "#instagood", "#wanderlust", "#instatravel", "#adventure", "#picoftheday", "#travelblogger", "#instagram", "#trip", "#beautiful", "#landscape", "#explore", "#traveling", "#vacation", "#ig", "#photo", "#like", "#travelling", "#naturephotography", "#art", "#summer", "#beach", "#holiday", "#bhfyp" };
            string[] CommonHashtagArray = { "#technology", "#tech", "#innovation", "#engineering", "#business", "#iphone", "#science", "#design", "#apple", "#electronics", "#technews", "#gadgets", "#smartphone", "#android", "#instagood", "#pro", "#software", "#programming", "#computer", "#samsung", "#instatech", "#bhfyp", "#gadget", "#security", "#mobile", "#coding", "#education", "#techie", "#future", "#bhfyp" };
            return Tuple.Create(BirdHashtagArray, AnimalHashtagArray, TravelHashtagArray, CommonHashtagArray,percent);
        }
    }
}

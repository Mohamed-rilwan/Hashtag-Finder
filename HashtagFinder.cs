using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hashtag_Finder
{
   public class HashtagFinder
    {
        public static List<string> HashtagFind(string hashtag,int type)
        {
            // A array of authors  
            List<string> BirdHashtag = new List<string>();
            List<string> AnimalHashtag = new List<string>();
            List<string> TravelHashtag = new List<string>();
            List<string> CommonHashtag = new List<string>();
            List<string> returnHashtag = new List<string>();

            List<string> OutputHashtag = new List<string>();

            string[] BirdHashtagArray = { "#bird", "#birdphotography", "#birdsoginstagram", "#birdwatching", "#birdsogprey", "#nature", "#wildlife", "#wanderrex", "#naturephotography", "#wildlifephotography", "#bestbirdshots", "#bird_captures", "#birdplanet", "#birdlife", "#bird_watchers_daily", "#wildlifeplanet" };
            string[] AnimalHashtagArray = { };
            string[] TravelHashtagArray = { };
            string[] CommonHashtagArray = { };

            if (type == 1)
            {
                BirdHashtag.Add(hashtag);
            }
            if (type == 2)
            {
                AnimalHashtag.Add(hashtag);
            }
            if (type == 3)
            {
                TravelHashtag.Add(hashtag);
            }
            if (type == 0)
            {
                CommonHashtag.Add(hashtag);
            }

            int birdCount = Convert.ToInt32(BirdHashtagArray.Length * 0.7);
            int animalCount = Convert.ToInt32(AnimalHashtagArray.Length * 0.7);
            int travelCount = Convert.ToInt32(TravelHashtagArray.Length * 0.7);
            int commonCount = Convert.ToInt32(CommonHashtagArray.Length);
            Random rand = new Random();
            List<int> birdNumber = new List<int>();
            List<int> animalNumber = new List<int>();
            List<int> travelNumber = new List<int>();
            List<int> commonNumber = new List<int>();

            int number1;
            for (int i = 0; i < birdNumber.Count; i++)
            {
                do
                {
                    number1 = rand.Next(1, BirdHashtagArray.Length);
                } while (birdNumber.Contains(number1));
                birdNumber.Add(number1);
            }

            int number2;
            for (int i = 0; i < animalCount; i++)
            {
                do
                {
                    number2 = rand.Next(1, AnimalHashtagArray.Length);
                } while (animalNumber.Contains(number2));
                animalNumber.Add(number2);
            }

            int number3;
            for (int i = 0; i < travelCount; i++)
            {
                do
                {
                    number3 = rand.Next(1, TravelHashtagArray.Length);
                } while (travelNumber.Contains(number3));
                travelNumber.Add(number3);
            }

            int number4;
            for (int i = 0; i < commonCount; i++)
            {
                do
                {
                    number4 = rand.Next(1, CommonHashtagArray.Length);
                } while (commonNumber.Contains(number4));
                commonNumber.Add(number4);
            }


            if (type == 1)
            {
               
                for (int i = 0; i < birdNumber.Count; i++)
                {
                    returnHashtag.Add(BirdHashtagArray[i]);
                }
            }
            else if (type == 2 )
            {
                for (int i = 0; i < animalNumber.Count; i++)
                {
                    returnHashtag.Add(AnimalHashtagArray[i]);
                }
            }
            else if (type == 3)
            {
                for (int i = 0; i < travelNumber.Count; i++)
                {
                    returnHashtag.Add(AnimalHashtagArray[i]);
                }
            }
            else if (type == 0)
            {
                for (int i = 0; i < commonNumber.Count; i++)
                {
                    returnHashtag.Add(AnimalHashtagArray[i]);
                }
            }

            return (returnHashtag);
        }
    }
}

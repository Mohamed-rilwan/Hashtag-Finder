using HashtagFinder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

            List<string> BirdHashtag = new List<string>();
            List<string> AnimalHashtag = new List<string>();
            List<string> TravelHashtag = new List<string>();
            List<string> CommonHashtag = new List<string>();
            List<string> CombinationHashtag = new List<string>();
            List<string> returnHashtag = new List<string>();

            List<string> OutputHashtag = new List<string>();

            Tuple<string[], string[], string[], string[],int> value = Constant.Values();
            string[] BirdHashtagArray = value.Item1;
            string[] AnimalHashtagArray = value.Item2;
            string[] TravelHashtagArray = value.Item3;
            string[] CommonHashtagArray = value.Item4;
            
            int percent = value.Item5;
           
            int birdCount = Convert.ToInt32(BirdHashtagArray.Length * percent);
            int animalCount = Convert.ToInt32(AnimalHashtagArray.Length * percent);
            int travelCount = Convert.ToInt32(TravelHashtagArray.Length * percent);
            int commonCount = Convert.ToInt32(CommonHashtagArray.Length * percent);
            Random rand = new Random();
            List<int> birdNumber = new List<int>();
            List<int> animalNumber = new List<int>();
            List<int> travelNumber = new List<int>();
            List<int> commonNumber = new List<int>();
            List<int> combineNumber = new List<int>();

            if (type == 1)
            {
                int number1;
                for (int i = 0; i < birdCount; i++)
                {
                    do
                    {
                        number1 = rand.Next(0, BirdHashtagArray.Length);
                    } while (birdNumber.Contains(number1));
                    birdNumber.Add(number1);
                }

                for (int i = 0; i < birdNumber.Count; i++)
                {
                    returnHashtag.Add(BirdHashtagArray[i]);
                }
            }

            else if (type == 2)
            {

                int number2;
                for (int i = 0; i < travelCount; i++)
                {
                    do
                    {
                        number2 = rand.Next(0, TravelHashtagArray.Length);
                    } while (travelNumber.Contains(number2));
                    travelNumber.Add(number2);
                }

                for (int i = 0; i < travelNumber.Count; i++)
                {
                    returnHashtag.Add(TravelHashtagArray[i]);
                }
            }

            else if (type == 3 )
            {
                int number3;
                for (int i = 0; i < animalCount; i++)
                {
                    do
                    {
                        number3 = rand.Next(0, AnimalHashtagArray.Length);
                    } while (animalNumber.Contains(number3));
                    animalNumber.Add(number3);
                }
                for (int i = 0; i < animalNumber.Count; i++)
                {
                    returnHashtag.Add(AnimalHashtagArray[i]);
                }
            }
         
            else if (type == 4 )
            {

                int number4;
                for (int i = 0; i < commonCount ; i++)
                {
                    do
                    {
                        number4 = rand.Next(0, CommonHashtagArray.Length);
                    } while (commonNumber.Contains(number4));
                    commonNumber.Add(number4);
                }
                for (int i = 0; i < commonNumber.Count; i++)
                {
                    returnHashtag.Add(CommonHashtagArray[i]);
                }
            }

            return (returnHashtag);
        }
    }
}

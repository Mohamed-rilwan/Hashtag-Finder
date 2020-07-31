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
            var CombinationHashtag = new List<string>();
            List<string> returnHashtag = new List<string>();

            List<string> OutputHashtag = new List<string>();

            Tuple<string[], string[], string[],int> value = Constant.Values();
            string[] BirdHashtagArray = value.Item1;
            string[] AnimalHashtagArray = value.Item2;
            string[] TravelHashtagArray = value.Item3;
            
            int percent = value.Item4;
           
            int birdCount = Convert.ToInt32(BirdHashtagArray.Length * percent);
            int animalCount = Convert.ToInt32(AnimalHashtagArray.Length * percent);
            int travelCount = Convert.ToInt32(TravelHashtagArray.Length * percent);

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
                    returnHashtag.Add(BirdHashtagArray[birdNumber[i]]);
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
                    returnHashtag.Add(TravelHashtagArray[travelNumber[i]]);
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
                    returnHashtag.Add(AnimalHashtagArray[animalNumber[i]]);
                }
            }
         
            else if (type == 4 )
            {
                CombinationHashtag.Clear();
                combineNumber.Clear();
                CombinationHashtag.AddRange(BirdHashtagArray);
                CombinationHashtag.AddRange(AnimalHashtagArray);
                CombinationHashtag.AddRange(TravelHashtagArray);
                string[] birdAnimalTravel = CombinationHashtag.ToArray();

                int number4;

                for (int i = 0; i < CombinationHashtag.Count; i++)
                {
                    do
                    {
                        number4 = rand.Next(0, CombinationHashtag.Count);
                    } while (combineNumber.Contains(number4));
                    combineNumber.Add(number4);
                }
                for (int i = 0; i < combineNumber.Count; i++)
                {
                    returnHashtag.Add(birdAnimalTravel[combineNumber[i]]);
                }
            }

            else if (type == 5)
            {
                CombinationHashtag.Clear();
                combineNumber.Clear();
                CombinationHashtag.AddRange(BirdHashtagArray);
                CombinationHashtag.AddRange(AnimalHashtagArray);
                string[] birdAnimal = CombinationHashtag.ToArray();

                int number5;

                for (int i = 0; i < CombinationHashtag.Count; i++)
                {
                    do
                    {
                        number5 = rand.Next(0, CombinationHashtag.Count);
                    } while (combineNumber.Contains(number5));
                    combineNumber.Add(number5);
                }
                for (int i = 0; i < combineNumber.Count; i++)
                {
                    returnHashtag.Add(birdAnimal[combineNumber[i]]);
                }
            }

            else if (type == 6)
            {
                CombinationHashtag.Clear();
                combineNumber.Clear();
                CombinationHashtag.AddRange(AnimalHashtagArray);
                CombinationHashtag.AddRange(TravelHashtagArray);
                string[] animalTravel = CombinationHashtag.ToArray();

                int number6;

                for (int i = 0; i < CombinationHashtag.Count; i++)
                {
                    do
                    {
                        number6 = rand.Next(0, CombinationHashtag.Count);
                    } while (combineNumber.Contains(number6));
                    combineNumber.Add(number6);
                }
                for (int i = 0; i < combineNumber.Count; i++)
                {
                    returnHashtag.Add(animalTravel[combineNumber[i]]);
                }
            }

            else if (type == 7)
            {
                CombinationHashtag.Clear();
                combineNumber.Clear();
                CombinationHashtag.AddRange(BirdHashtagArray);
                CombinationHashtag.AddRange(TravelHashtagArray);
                string[] birdTravel = CombinationHashtag.ToArray();

                int number7;

                for (int i = 0; i < CombinationHashtag.Count; i++)
                {
                    do
                    {
                        number7 = rand.Next(0, CombinationHashtag.Count);
                    } while (combineNumber.Contains(number7));
                    combineNumber.Add(number7);
                }
                for (int i = 0; i < combineNumber.Count; i++)
                {
                    returnHashtag.Add(birdTravel[combineNumber[i]]);
                }
            }
            return (returnHashtag);
        }
    }
}

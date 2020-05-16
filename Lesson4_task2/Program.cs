using System;
using System.Collections.Generic;


//Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции: для целых чисел;

namespace Lesson4_task2
{
    class Program
    {
        const int count = 10;
        static int counter;

        static Random rnd = new Random();
        static List<int> someList = new List<int>(count);
        static Dictionary<int, int> someDictionary = new Dictionary<int, int>();

        private static int Randomizer(Random rnd)
        {
            return rnd.Next(1, 10);
        }

        static void Main(string[] args)
        {
            //Заполняю коллекцию
            for(int i = 0; i < someList.Capacity; i++)
                someList.Add(Randomizer(rnd));

            //Подсчет вхождений
            for(int i = 0; i < someList.Count; i++)
            {
                counter = 1;
                for (int j = i + 1; j < someList.Count -1; j++)
                {
                    if (someList[i] == someList[j])
                        counter++;
                }

                if (!someDictionary.ContainsKey(someList[i]))
                    someDictionary.Add(someList[i], counter);
            }

            foreach(var item in someList)
                Console.WriteLine(item);

            foreach (KeyValuePair<int, int> kvp in someDictionary)
                Console.WriteLine($"{kvp.Key}: входит {kvp.Value} раз");
        }
    }
}

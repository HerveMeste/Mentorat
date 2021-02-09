using Mentorat.Class;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mentorat
{
    internal class MethodsSort
    {
        public static void AllElementbyWeigth(List<ArrayJson> listJson)
        {
            Console.WriteLine("Choose your weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            List<int> arrayJsons = new List<int>();
            for (int i = 0; i < listJson.Count(); i++)
            {
                if (weight == listJson[i].weight)
                {
                    arrayJsons.Add(weight);
                }
            }
            Console.WriteLine($"There is {arrayJsons.Count()} elements with your weight {weight}");

        }

        public static void ElementByLabel(List<ArrayJson> listJson)
        {
            Console.WriteLine("choose a number for your label");
            int numberLabel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your label is : {listJson[numberLabel].label}");

        }
        public static void GetElementByIndex(List<ArrayJson> listJson)
        {
            Console.WriteLine("choose your index");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{listJson[index].label} {listJson[index].weight}");

        }
        public static void GetElementByWeigth(List<ArrayJson> listJson)
        {
            Console.WriteLine("choose your weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose your index");
            int index = Convert.ToInt32(Console.ReadLine());
            List<ArrayJson> arrayJsons = new List<ArrayJson>();
            for (int i = 0; i < listJson.Count(); i++)
            {
                if (weight == listJson[i].weight)
                {
                    arrayJsons.Add(listJson[i]);
                }
            }
            for (int i = 0; i < arrayJsons.Count(); i++)
            {
                if (index < arrayJsons.Count())
                {
                    Console.WriteLine($"your index weight is {arrayJsons[index].label} {arrayJsons[index].weight}");
                    break;

                }
                else
                {
                    Console.WriteLine("Take an Index smaller");
                    break;
                }
            }


        }
        public static void LastElementByWeigth(List<ArrayJson> listJson)
        {
            Console.WriteLine("choose your weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            bool verify = false;
            for (int i = 0; i < listJson.Count(); i++)
            {
                if (weight == listJson[i].weight)
                {
                    index = i;
                    verify = true;
                }

            }
            if (verify == true)
            {
                Console.WriteLine($"Your last Index with your weight : {weight} is {index}");
            }

        }
    }
}
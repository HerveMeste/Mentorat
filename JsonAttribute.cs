using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mentorat.Class
{
    public class JsonAttribute
    {
        private int _weight;
        private string _label;

        public JsonAttribute(int weight, string label)
        {
            _weight = weight;
            _label = label;
        }

        public static void AllElementbyWeigth(List<JsonAttribute> JsonToProcess)
        {
            Console.WriteLine("Choose your weight");
            int userEnteredWeight = Convert.ToInt32(Console.ReadLine());
            List<int> arrayWeight = new List<int>();
            for (int i = 0; i < JsonToProcess.Count(); i++)
            {
                if (userEnteredWeight == JsonToProcess[i]._weight)
                {
                    arrayWeight.Add(userEnteredWeight);
                }
            }
            Console.WriteLine($"There is {arrayWeight.Count()} elements with your weight {userEnteredWeight}");

        }

        public static void ElementByLabel(List<JsonAttribute> JsonToProcess)
        {
            Console.WriteLine("choose a number for your label");
            int numberLabel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your label is : {JsonToProcess[numberLabel]._label}");

        }
        public static void GetElementByIndex(List<JsonAttribute> JsonToProcess)
        {
            Console.WriteLine("choose your index");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{JsonToProcess[index]._label} {JsonToProcess[index]._weight}");

        }
        public static void GetElementByWeigth(List<JsonAttribute> JsonToProcess)
        {
            Console.WriteLine("choose your weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose your index");
            int index = Convert.ToInt32(Console.ReadLine());
            List<JsonAttribute> arrayJsons = new List<JsonAttribute>();
            for (int i = 0; i < JsonToProcess.Count(); i++)
            {
                if (weight == JsonToProcess[i]._weight)
                {
                    arrayJsons.Add(JsonToProcess[i]);
                }
            }
            while(true)
            {
                if (index < arrayJsons.Count())
                {
                    Console.WriteLine($"your index weight is {arrayJsons[index]._label} {arrayJsons[index]._weight}");
                    break;

                }
                else
                {
                    Console.WriteLine("Take an Index smaller");
                    break;
                }
            }


        }
        public static void LastElementByWeigth(List<JsonAttribute> JsonToProcess)
        {
            Console.WriteLine("choose your weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < JsonToProcess.Count(); i++)
            {
                if (weight == JsonToProcess[i]._weight)
                {
                    index = i;
                    
                }

            }
             Console.WriteLine($"Your last Index with your weight : {weight} is {index}");   

        }
    }
    
}
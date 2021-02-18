using Mentorat.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Mentorat
{
    class Program : JsonAttribute
    {
        public Program(int weight, string label) : base(weight, label)
        {
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose your method 1:elementbyId 2:LastElementByWeight 3:AllElementByWeight" +
                    "5 4: GetElementByWeight 5:GetElementByIndex");
                string numberMethod = Console.ReadLine();
                List<JsonAttribute> JsonFile = ChooseOneJsonFile();
                switch (numberMethod)
                {
                    case "1":
                        ElementByLabel(JsonFile);
                        break;
                    case "2":
                        LastElementByWeigth(JsonFile);
                        break;
                    case "3":
                        AllElementbyWeigth(JsonFile);
                        break;
                    case "4":
                        GetElementByWeigth(JsonFile);
                        break;
                    case "5":
                        GetElementByIndex(JsonFile);
                        break;
                }

            }
        }

        private static List<JsonAttribute> ChooseOneJsonFile()
        {
            Console.WriteLine("choose a file among these 3 : Files 1 (1k), file2(50k), file3(1M)");
            int userEntryJsonFile = Convert.ToInt32(Console.ReadLine());
            List<JsonAttribute> JsonFile = new List<JsonAttribute>();
            if (userEntryJsonFile == 1)
            {
                StreamReader thousand = new StreamReader(@"C:\Users\Hervé\source\repos\Mentorat\Json Class\1K.json");
                string json = thousand.ReadToEnd();
                JsonFile = JsonConvert.DeserializeObject<List<JsonAttribute>>(json);

            }
            else if (userEntryJsonFile == 2)
            {
                StreamReader thousand = new StreamReader(@"C:\Users\Hervé\source\repos\Mentorat\Json Class\50K.json");
                string json = thousand.ReadToEnd();
                JsonFile = JsonConvert.DeserializeObject<List<JsonAttribute>>(json);
            }
            else
            {
                StreamReader thousand = new StreamReader(@"C:\Users\Hervé\source\repos\Mentorat\Json Class\1M.json");
                string json = thousand.ReadToEnd();
                JsonFile = JsonConvert.DeserializeObject<List<JsonAttribute>>(json);
            }

            return JsonFile;
        }


        


    }
}

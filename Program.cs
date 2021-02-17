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
                int numberMethod = Convert.ToInt32(Console.ReadLine());
                if(numberMethod == 1)
                {
                    List<JsonAttribute> listJson = ChooseListJson();
                    ElementByLabel(listJson);
                }
                if(numberMethod == 2)
                {
                    List<JsonAttribute> listJson = ChooseListJson();
                    LastElementByWeigth(listJson);
                }
                if(numberMethod == 3)
                {
                    List<JsonAttribute> listJson = ChooseListJson();
                    AllElementbyWeigth(listJson);
                }
                if (numberMethod == 4)
                {
                    List<JsonAttribute> listJson = ChooseListJson();
                    GetElementByWeigth(listJson);
                }
                if (numberMethod == 5)
                {
                    List<JsonAttribute> listJson = ChooseListJson();
                    GetElementByIndex(listJson);
                }

            }
        }

        private static List<JsonAttribute> ChooseListJson()
        {
            Console.WriteLine("Choose file1(1K), files2(50k) or 3(1M)");
            int userEntryJsonFile = Convert.ToInt32(Console.ReadLine());
            List<JsonAttribute> listJson = new List<JsonAttribute>();
            if (userEntryJsonFile == 1)
            {
                StreamReader thousand = new StreamReader(@"C:\Users\Hervé\source\repos\Mentorat\Json Class\1K.json");
                string json = thousand.ReadToEnd();
                listJson = JsonConvert.DeserializeObject<List<JsonAttribute>>(json);

            }
            else if (userEntryJsonFile == 2)
            {
                StreamReader thousand = new StreamReader(@"C:\Users\Hervé\source\repos\Mentorat\Json Class\50K.json");
                string json = thousand.ReadToEnd();
                listJson = JsonConvert.DeserializeObject<List<JsonAttribute>>(json);
            }
            else
            {
                StreamReader thousand = new StreamReader(@"C:\Users\Hervé\source\repos\Mentorat\Json Class\1M.json");
                string json = thousand.ReadToEnd();
                listJson = JsonConvert.DeserializeObject<List<JsonAttribute>>(json);
            }

            return listJson;
        }


        


    }
}

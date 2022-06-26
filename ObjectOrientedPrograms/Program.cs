using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating the Datamangement lsit

            List<DataManagement> list = new List<DataManagement>()
            {
                //Adding the information to the list
                new DataManagement("Rice", 1, 45),
                new DataManagement("Pulses", 2, 100),
                new DataManagement("Wheat", 3, 165),
            };
            
            //Using JSON Converter Printing the information in the list
            var result = JsonConvert.SerializeObject(list,Formatting.Indented);
            Console.WriteLine(result);
            
        }
        public class DataManagement
        {
            public string Name;
            public int Weight;
            public int Price;

            public DataManagement(string Name, int Weight, int Price)
            {
                this.Name = Name;
                this.Weight = Weight;
                this.Price = Price;
            }
        }

    }
}

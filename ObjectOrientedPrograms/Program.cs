using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DataManagement> list = new List<DataManagement>()
            {
                new DataManagement("Rice", 1, 45),
                new DataManagement("Pulses", 2, 100),
                new DataManagement("Wheat", 3, 165),
            };
            

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

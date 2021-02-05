using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryBusinessLayer
{
    public class InventoryLogic
    {
        //List of InventoryItem(s) to be used in presentation layer
        public List<InventoryItem> Items { get; set; }

        /// <summary>
        /// constructor that initializes Items List
        /// </summary>
        public InventoryLogic()
        {
            Items = new List<InventoryItem>();
        }

        /// <summary>
        /// reads a file and adds its contents to the list of items we have
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> ReadFile()
        {
            //clears list in case of multiple loads
            Items.Clear();
            //reads text file using streamreader
            using (StreamReader stream = new StreamReader(@"..\Resources\items.txt"))
            {
                string line = "";
                //reads each line of a text file and separates the data
                while((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    decimal cost = decimal.Parse(parts[2]);
                    string description = parts[3];
                    //creates a new InventoryItem object and adds it to the list of items
                    Items.Add(new InventoryItem(id, name, cost, description));
                }
            }
            //returns the list of InventoryItem(s)
            return Items;
        }
    }
}

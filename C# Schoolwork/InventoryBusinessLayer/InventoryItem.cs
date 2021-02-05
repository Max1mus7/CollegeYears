using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBusinessLayer
{
    public class InventoryItem
    {
        //declares properties
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// constructor, initializes properties
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>
        public InventoryItem(int id, string name, decimal cost, string description)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Description = description;
        }
    }
}

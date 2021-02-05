using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryBusinessLayer;

namespace InventoryPresentationLayer
{
    public partial class Form1 : Form
    {
        //creates a new object of the InventoryLogic type
        InventoryLogic IL = new InventoryLogic();
        public Form1()
        {
            InitializeComponent();
            
            //creates a new datatable to hold the items and be the source for the datagridview on the form
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            //add columns to the datatable
            dt.Columns.Add("Item ID", typeof(int));
            dt.Columns.Add("Item Name", typeof(string));
            dt.Columns.Add("Item Cost", typeof(decimal));
            dt.Columns.Add("Item Description", typeof(string));
            //Populates the item list in the InventoryLogic object
            IL.ReadFile();
            //uses the Items list in the InventoryLogic object in order to populate the datatable
            foreach(InventoryItem item in IL.Items)
            {
                dt.Rows.Add(item.ID, item.Name, item.Cost, item.Description);
            }
        }
    }
}

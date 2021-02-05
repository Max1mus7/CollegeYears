using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileDataAccessDemo;
using System.IO;

namespace TextFileDataAccessGUI
{
    public partial class Form1 : Form
    {
        //declares and inititalizes a new list of type Person to be used elsewhere in the program
        List<Person> people = new List<Person>();
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Modifies the Click event listener for the button to add a new person
        /// Adds a new string representation of a Person to the listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            //check for empty text boxes
            if (!tbFirstName.Text.Equals("") && !tbLastName.Text.Equals("") && !tbUrl.Text.Equals(""))
            {
                people.Add(new Person(tbFirstName.Text, tbLastName.Text, tbUrl.Text));
            }
            else
            {
                MessageBox.Show("Invalid input, please make sure that" + Environment.NewLine + "all fields are filled before submitting.");
            }
            //prevents adding too much data
            lbPeople.Items.Clear();
            //repopulates the listbox
            foreach(Person person in people)
            {
                lbPeople.Items.Add(person.ToString());
            }
        }

        /// <summary>
        /// populates the listbox by reading from a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            //utilizes StreamReader efficiently
            using (StreamReader stream = new StreamReader(@"..\people.txt"))
            {
                //clears the array of people used in order to repopulate it using the file data
                people.Clear();
                //placeholder string
                string line = "";
                //makes sure all data is retrieved
                while((line = stream.ReadLine()) != null)
                {
                    //splits data to create a new person to add to the people List
                    string[] lineparts = line.Split(",");
                    if(lineparts.Length == 3)
                    {
                        string firstname = lineparts[0];
                        string lastname = lineparts[1];
                        string url = lineparts[2];
                        people.Add(new Person(firstname, lastname, url));
                    }
                    else
                    {
                        people.Add(new Person());
                    }
                }
                lbPeople.Items.Clear();
                foreach (Person person in people)
                {
                    lbPeople.Items.Add(person.ToString());
                }
            }
        }

        /// <summary>
        /// saves a string representation of the current Person list to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string contents = "";
            foreach(Person person in people)
            {
                contents += string.Format("{0},{1},{2}", person.FirstName, person.LastName, person.Url) + Environment.NewLine;
            }
            File.WriteAllText(@"..\people.txt", contents);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OOCA_3
{
    public partial class TextFileScanning : Form
    {
        private string longestWord = "";
        private string firstAlphabetical = "";
        private string lastAlphabetical = "";
        private string inputText;

        public TextFileScanning()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    StreamReader sr = new StreamReader(fs);
                    inputText = sr.ReadToEnd();
                    string[] inputLines = inputText.Split(' ');
                    firstAlphabetical = inputLines[0];
                    lastAlphabetical = inputLines[inputLines.Length - 1];
                    longestWord = inputLines[0];
                    for (int i = 0; i < inputLines.Length; i++)
                    {
                        if (longestWord.Length < inputLines[i].Length)
                        {
                            longestWord = inputLines[i];
                        }
                    }
                    fileDisplay.Text = inputText;
                    statsDisplay.Text = "First Word Alphabetically: " + firstAlphabetical + "\r\nLast Word Alphatbetically: " + lastAlphabetical +
                            "\r\nLongest Word: " + longestWord;
                }
                using (StreamWriter sw = new StreamWriter(openFileDialog1.FileName, false))
                {
                    sw.Write(inputText.ToLower());
                }
                using (StreamWriter sw = new StreamWriter("C:\\Users\\poker\\Desktop\\OOCA-3Out.txt", false))
                {
                    sw.Write("First Word Alphabetically: " + firstAlphabetical + "\r\nLast Word Alphatbetically: " + lastAlphabetical + "\r\nLongest Word: " + longestWord);
                }
            }
        }
    }
}
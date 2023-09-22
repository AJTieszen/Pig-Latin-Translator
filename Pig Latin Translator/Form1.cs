using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pig_Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            englishText.Clear();
            pigLatinText.Clear();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string english = englishText.Text.Trim();
            if (!string.IsNullOrEmpty(english))
            {
                string[] words = english.Split(' ');
                string pigLatin = "";

                foreach (string word in words)
                {
                    pigLatin += translateWord(word) + " ";
                }

                pigLatinText.Text = pigLatin;
            }
            else
            {
                MessageBox.Show("You must enter some text to translate.", "Enter text");
                englishText.Focus();
            }
        }

        private string translateWord(string word)
        {
            return word;
        }
    }
}

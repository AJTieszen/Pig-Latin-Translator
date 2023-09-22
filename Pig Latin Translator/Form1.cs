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
                    pigLatin += TranslateWordWithCaps(word) + " ";
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
            char c = word[0];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                word += "way";
            }
            else
            {
                word = word.Remove(0, 1);
                word += c.ToString();
                c = word[0];

                while (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && c != 'y'&&
                    c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U' && c != 'y')
                {
                    word = word.Remove(0, 1);
                    word += c.ToString();
                    c = word[0];
                }
                word += "ay";
            }

            return word;
        }

        private string TranslateWordWithCaps(string word)
        {
            String punct = "";
            int length = word.Length;

            if (word.EndsWith(".") || word.EndsWith(",") || word.EndsWith(";") || word.EndsWith(":") ||
                word.EndsWith("!") || word.EndsWith("?"))
            {
                punct = word.Substring(word.Length - 1);
                word = word.Remove(length - 1, 1);
            }

            word = translateWord(word);
            word += punct;

            return word;
        }
    }
}

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

        private string TranslateWord(string word)
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

            if (IsInitialCap(word))
                word = ToInitialCap(TranslateWord(word));
            else if (IsUpper(word))
                word = TranslateWord(word).ToUpper();
            else if (IsLower(word))
                word = TranslateWord(word).ToLower();

            word += punct;

            return word;
        }

        private bool IsUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!IsUpper(word[i]))
                    return false;
            }
            return true;
        }

        private bool IsLower(string word)
        {
            for (int i =0; i < word.Length; i++)
            {
                if (!IsLower(word[i]))
                    return false;
            }
            return true;
        }

        private bool IsInitialCap(string word)
        {
            char firstLetter = word[0];
            string otherLetters = word.Remove(0, 1);
            if (IsUpper(firstLetter) && IsLower(otherLetters))
                return true;
            else
                return false;
        }

        private bool IsUpper(char c)
        {
            if ((c >= 'A' && c <= 'Z') || c.ToString() == "'")
                return true;
            else
                return false;
        }

        private bool IsLower(char c)
        {
            if ((c >= 'a' && c <= 'z') || c.ToString() == "'")
                return true;
            else
                return false;
        }

        private string ToInitialCap(string word)
        {
            string firstletter = word.Substring(0, 1).ToUpper();
            string otherLetters = word.Substring(1).ToLower();
            return firstletter + otherLetters;
        }
    }
}

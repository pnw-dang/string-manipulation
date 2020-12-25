using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManipulation
{
    public partial class StringManipulation : Form
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        public StringManipulation()
        {
            InitializeComponent();
        }

        private void CharAndVowelBtn_Click(object sender, EventArgs e)
        {
            string stringInput = InputTxtBox.Text;
            int characterCounter = 0;
            int vowelCounter = 0;

            foreach (char ch in stringInput)
            {
                if (Char.IsLetterOrDigit(ch) || Char.IsPunctuation(ch))
                {
                    characterCounter++;
                }
                if (vowels.Contains(ch))
                {
                    vowelCounter++;
                }
            }
            DisplayRichTB.Text = "The input string has: \n" + $"{characterCounter} characters \n" + $"{vowelCounter} vowels";
        }

        private void FirstMiddleLastBtn_Click(object sender, EventArgs e)
        {
            string stringInput = InputTxtBox.Text;
            char firstCharacter = stringInput[0];
            char middleCharacter = stringInput[stringInput.Length / 2];
            char lastCharacter = stringInput[stringInput.Length - 1];

            DisplayRichTB.Clear();
            DisplayRichTB.AppendText("The first character is: " + $"{firstCharacter} \n" +
                $"The middle character is: " + $"{middleCharacter} \n" +
                $"The last character is: " + $"{lastCharacter} \n");
        }

        private void RemoveSecLastBtn_Click(object sender, EventArgs e)
        {
            string stringInput = InputTxtBox.Text;
            string reversedString = new string(stringInput.Reverse().ToArray());

            int index = reversedString.IndexOf(' ');
            int secondIndex = reversedString.IndexOf(' ', index + 1);

            if (index != secondIndex && index >= 0)
            {
                string stringOutput = reversedString.Remove(index + 1, secondIndex - index);
                string reversedString2 = new string(stringOutput.Reverse().ToArray());
                DisplayRichTB.Text = "The new string is: \n" + reversedString2;
            }
        }

        private void IndexBtn_Click(object sender, EventArgs e)
        {
            string stringInput = InputTxtBox.Text;
            DisplayRichTB.Clear();
            DisplayRichTB.AppendText("The index of the first vowel is: " + stringInput.IndexOfAny(vowels));
        }

        private void RemoveVowelsBtn_Click(object sender, EventArgs e)
        {
            string newSentence = InputTxtBox.Text;
            newSentence = new string(newSentence.Where(ch => !vowels.Contains(ch)).ToArray());
            DisplayRichTB.Clear();
            DisplayRichTB.AppendText("The new string is: " + "'" + newSentence + "'");
        }

    }
}


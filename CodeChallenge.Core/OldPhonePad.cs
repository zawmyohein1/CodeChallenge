using System;
using System.Text;
using System.Collections.Generic;

namespace CodeChallenge.Core
{
    public class OldPhonePad
    {
        #region KeyPad Mapping

        //A dictionary keypad maps each number to its corresponding letters.
        private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
        {
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"},
            {'0', " "}
        };

        #endregion

        #region ParseInput

        //The ParseInput method iterates through each character in the input string.

        //If the character is #, it breaks out of the loop as it signifies the end of the input.
        //If the character is *, it simulates a backspace by removing the last character from the output.
        //If the character is a space, it resets lastChar to indicate a pause.
        //Otherwise, it processes the character:
        //    If the character is the same as the previous character (lastChar), it increments the count.
        //    If the character is different, it appends the corresponding letter of the previous character to the output and resets the lastChar and count.

        public static string ParseInput(string input)
        {
            StringBuilder output = new StringBuilder();
            int count = 0;
            char lastChar = '\0';

            foreach (char ch in input)
            {
                if (ch == '#')
                {
                    break;
                }
                else if (ch == '*')
                {
                    if (output.Length > 0)
                    {
                        output.Length--;
                    }
                }
                else if (ch == ' ')
                {
                    lastChar = '\0';
                }
                else
                {
                    if (ch == lastChar)
                    {
                        count++;
                    }
                    else
                    {
                        if (lastChar != '\0')
                        {
                            output.Append(GetCharacter(lastChar, count));
                        }
                        lastChar = ch;
                        count = 1;
                    }
                }
            }

            if (lastChar != '\0')
            {
                output.Append(GetCharacter(lastChar, count));
            }

            return output.ToString();
        }

        #endregion

        #region GetCharacter

        //The GetCharacter method determines the correct letter based on the key pressed and the count of presses.
        //It handles wrapping around using the modulo operator.

        private static char GetCharacter(char key, int pressCount)
        {
            if (keypad.ContainsKey(key))
            {
                string letters = keypad[key];
                int index = (pressCount - 1) % letters.Length;
                return letters[index];
            }
            throw new ArgumentException($"Invalid key: {key}");
        }

        #endregion
    }
}

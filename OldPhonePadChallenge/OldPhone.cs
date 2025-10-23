using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePadChallenge
{
    public static class OldPhone
    {
        public static string OldPhonePad(string input)
        {
            Dictionary<char, string> keypad = new Dictionary<char, string>
            {
                { '1', ".,!?" },
                { '2', "ABC" },
                { '3', "DEF" },
                { '4', "GHI" },
                { '5', "JKL" },
                { '6', "MNO" },
                { '7', "PQRS" },
                { '8', "TUV" },
                { '9', "WXYZ" },
                { '0', " " }
            };

            StringBuilder result = new StringBuilder();
            List<(char key, int count)> sequence = new List<(char, int)>();

            foreach (char c in input)
            {
                if (c == '#')
                {
                    foreach (var s in sequence)
                        result.Append(GetLetter(s.key, s.count, keypad));
                    break;
                }
                else if (c == '*')
                {
                    if (sequence.Count > 0)
                        sequence.RemoveAt(sequence.Count - 1);
                }
                else if (c == ' ')
                {
                    if (sequence.Count > 0)
                    {
                        foreach (var s in sequence)
                            result.Append(GetLetter(s.key, s.count, keypad));
                        sequence.Clear();
                    }
                }
                else if (keypad.ContainsKey(c))
                {
                    if (sequence.Count > 0 && sequence[sequence.Count - 1].key == c)
                    {
                        // Increment count if same key
                        sequence[sequence.Count - 1] = (c, sequence[sequence.Count - 1].count + 1);
                    }
                    else
                    {
                        sequence.Add((c, 1));
                    }
                }
            }

            return result.ToString();
        }

        private static string GetLetter(char key, int pressCount, Dictionary<char, string> keypad)
        {
            string letters = keypad[key];
            int index = (pressCount - 1) % letters.Length;
            return letters[index].ToString();
        }
    }
}

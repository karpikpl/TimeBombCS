using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TimeBomb
{
    public class Solver
    {
        private readonly static Dictionary<string, int> Numbers = new Dictionary<string, int>
        {
        {"***\n* *\n* *\n* *\n***",0},
        {"  *\n  *\n  *\n  *\n  *",1},
        {"***\n  *\n***\n*  \n***",2},
        {"***\n  *\n***\n  *\n***",3},
        {"* *\n* *\n***\n  *\n  *",4},
        {"***\n*  \n***\n  *\n***",5},
        {"***\n*  \n***\n* *\n***",6},
        {"***\n  *\n  *\n  *\n  *",7},
        {"***\n* *\n***\n* *\n***",8},
        {"***\n* *\n***\n  *\n***",9},
        {"   \n   \n   \n  *\n   ",0}
        };

        public static int ParseArray(string[] data)
        {
            var digitsCount = (data[0].Length + 1) / 4;

            var digits = new string[digitsCount];

            for (int i = 0; i < digitsCount; i++)
                for (int j = 0; j < data.Length; j++)
                {
                    var nextPiece = data[j].Substring(i * 4, 3);
                    digits[i] = digits[i] == null ? nextPiece : digits[i] + "\n" + nextPiece;
                }

            var intRes = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (!Numbers.ContainsKey(digits[i]))
                    Debug.WriteLine(digits[i]);

                intRes += (int)Math.Pow(10, digits.Length - i - 1) * Numbers[digits[i]];
            }

            return intRes;
        }
    }
}

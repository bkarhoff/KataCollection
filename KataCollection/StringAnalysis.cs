using System;
using System.Collections.Generic;
using System.Text;

namespace KataCollection {
    public class StringAnalysis {
        /// <summary>
        /// Count the number of Duplicates
        /// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. 
        /// The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.
        /// 
        /// Source: codewars.com
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int DuplicateCount(string str) {
            string lowerStr = str.ToLower();
            List<char> foundChars = new List<char>();
            List<char> dupChars = new List<char>();
            int count = 0;

            foreach(char i in lowerStr) {
                if(foundChars.Contains(i) && !dupChars.Contains(i)) {
                    count++;
                    dupChars.Add(i);
                } else {
                    foundChars.Add(i);
                }
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <summary>
        /// Implement the function unique_in_order which takes as argument a sequence and returns a list of 
        /// items without any elements with the same value next to each other and preserving the original order of elements.
        ///
        /// For example:
        /// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
        /// uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
        /// uniqueInOrder([1,2,2,3,3])       == {1,2,3}
        /// 
        /// Source: codewars.com
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) {
            var orderedList = new List<T>();
            T previous = default(T);
            foreach(T i in iterable) {
                if(!i.Equals(previous)) {
                    orderedList.Add(i);
                    previous = i;
                }
            }
            return orderedList;
        }

    }
}

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
        /// <summary>
        /// A format for expressing an ordered list of integers is to use a comma separated list of either
        /// individual integers
        /// or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. 
        /// The range includes all integers in the interval including both endpoints.It is not considered a range unless it spans 
        /// at least 3 numbers.For example "12,13,15-17"
        /// Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.
        /// 
        /// Example:
        ///     solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
        ///     returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
        /// </summary>
        public static string Extract(int[] args) {
            string result = "";
            for(int i = 0; i < args.Length; i++) {
                result += args[i];
                if(i < args.Length - 1 && args[i] != args[i + 1] - 1) {
                    result += ",";
                } else if(i < args.Length - 2 && args[i] != args[i + 2] - 2) {
                    result += ",";
                } else {
                    i++;
                    while( i < args.Length - 1 && args[i] == args[i - 1] + 1 && args[i] == args[i + 1] - 1) {
                        i++;
                    }
                    result += $"-{args[i]},";
                }
            }
            return result; 
        }
    }
}

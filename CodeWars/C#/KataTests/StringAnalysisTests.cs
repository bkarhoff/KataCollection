using KataCollection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests {
    public class StringAnalysisTests {
        [Test]
        public void DuplicateCountTests() {
            Assert.AreEqual(0, StringAnalysis.DuplicateCount(""));
            Assert.AreEqual(0, StringAnalysis.DuplicateCount("abcde"));
            Assert.AreEqual(2, StringAnalysis.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, StringAnalysis.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, StringAnalysis.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, StringAnalysis.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
        [Test]
        public void UniqueInOrderTests() {
            Assert.AreEqual("", StringAnalysis.UniqueInOrder(""));
            Assert.AreEqual("ABCDAB", StringAnalysis.UniqueInOrder("AAAABBBCCDAABBB"));
        }
        [Test]
        public void ExtractTests() {
            Assert.AreEqual("1,2", StringAnalysis.Extract(new[] { 1, 2 }));
            Assert.AreEqual("1-3", StringAnalysis.Extract(new[] { 1, 2, 3 }));

            Assert.AreEqual(
                "-6,-3-1,3-5,7-11,14,15,17-20",
                StringAnalysis.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
            );

            Assert.AreEqual(
                "-3--1,2,10,15,16,18-20",
                StringAnalysis.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })
            );
        }
    }
}

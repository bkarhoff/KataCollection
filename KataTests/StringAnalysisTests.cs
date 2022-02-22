using KataCollection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests {
    public class StringAnalysisTests {
        [Test]
        public void KataTests() {
            Assert.AreEqual(0, StringAnalysis.DuplicateCount(""));
            Assert.AreEqual(0, StringAnalysis.DuplicateCount("abcde"));
            Assert.AreEqual(2, StringAnalysis.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, StringAnalysis.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, StringAnalysis.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, StringAnalysis.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}

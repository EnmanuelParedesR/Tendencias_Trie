using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trie;

namespace TrieTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddASingleWord()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("Jesu", "HolaMen");

            Assert.AreEqual("Jesu",Words.FindAllSimilarWords("Jesu")); //We need to override the ToString Method.
        }



    }
}

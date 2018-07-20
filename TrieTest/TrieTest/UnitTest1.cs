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

            Words.Add("jesu", "HolaMen");

            // We are not taking the Upper cases.

            Assert.AreEqual("jesu", Words.FindAllSimilarWords("jesu")); //We need to override the ToString Method.
        }

        [TestMethod]
        public void FindSimilarWords()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");

            Assert.AreEqual("jesu jesuq jesus jesuz", Words.FindAllSimilarWords("jesu"));
        }

        [TestMethod]
        public void AddMultiplesWord()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");

            Assert.AreEqual("jesu jesuq jesus jesuz", Words.FindAllSimilarWords("jesu")); //We need to override the ToString Method.
        }


        [TestMethod]
        public void AddAWordWithADigit()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("jesu1", "HolaMen");

            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu1"));
        }


        [TestMethod]
        public void AddJustASpaceInTheDictionary()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add(" ", "HolaMen");

            Assert.AreEqual("", Words.FindAllSimilarWords(""));
        }

        [TestMethod]
        public void AddEmptyWord()
        {
            Trie<string> Words = new Trie<string>();

            int result = Words.Add("", "");

            // We are not taking the Upper cases.

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void AddDigitInsteadOfWordWord()
        {
            Trie<string> Words = new Trie<string>();

            int result = Words.Add("NineButInDigit9", "");

            // We are not taking the Upper cases.

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void AddWhitespaceInsteadOfWordWord()
        {
            Trie<string> Words = new Trie<string>();

            int result = Words.Add("        ", "");

            // We are not taking the Upper cases.

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TrySearchWordWithBlank()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");

            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu ")); //We need to override the ToString Method.
        }

        [TestMethod]
        public void TrySearchWordWithDigit()
        {
            Trie<string> Words = new Trie<string>();
            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");
            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu9")); //We need to override the ToString Method.
        }
    }


}


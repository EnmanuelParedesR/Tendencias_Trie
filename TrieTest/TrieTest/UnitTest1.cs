using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trie;

namespace TrieTest
{
    [TestClass]
    public class UnitTest1
    {
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
        public void AddASingleWord()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("jesu", "HolaMen");

              // We are not taking the Upper cases.
    
            Assert.AreEqual("jesu",Words.FindAllSimilarWords("jesu")); //We need to override the ToString Method.
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
        [TestMethod]
        public void AddASingleWordWithUpcaseLettersWord()
        {
            Trie<string> Words = new Trie<string>();

            Words.Add("JESU", "HolaMen");

            // We are not taking the Upper cases.

            Assert.AreEqual("jesu", Words.FindAllSimilarWords("jesu")); //We need to override the ToString Method.
        }


>>>>>>> 883d6fc2ba1526b40278994624772250ea6d7e8d
=======
        
>>>>>>> parent of 8d424e3... Final Version
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
        public void TrySearchEmptyWord()
        {
            Trie<string> Words = new Trie<string>();

<<<<<<< HEAD
            Words.Add("jesu1", "HolaMen");
          

<<<<<<< HEAD
            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu1"));
=======
            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");
=======

            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu1"));  
        }
>>>>>>> parent of 8d424e3... Final Version

            Assert.AreEqual(null, Words.FindAllSimilarWords("")); //We need to override the ToString Method.
>>>>>>> 883d6fc2ba1526b40278994624772250ea6d7e8d
        }

        [TestMethod]
        public void TrySearchWordWithDigit()
        {
            Trie<string> Words = new Trie<string>();

<<<<<<< HEAD
            Words.Add(" ", "HolaMen");

     

            Assert.AreEqual("", Words.FindAllSimilarWords("")); 
        }


<<<<<<< HEAD
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

=======
            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");

            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu9")); //We need to override the ToString Method.
        }

        [TestMethod]
        public void TrySearchWordWithBlank()
        {
            Trie<string> Words = new Trie<string>();

>>>>>>> 883d6fc2ba1526b40278994624772250ea6d7e8d
            Words.Add("jesu", "HolaMen");
            Words.Add("jesuq", "HolaMen");
            Words.Add("jesus", "HolaMen");
            Words.Add("jesuz", "HolaMen");

            Assert.AreEqual(null, Words.FindAllSimilarWords("jesu ")); //We need to override the ToString Method.
        }
<<<<<<< HEAD

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
=======
>>>>>>> 883d6fc2ba1526b40278994624772250ea6d7e8d
=======
>>>>>>> parent of 8d424e3... Final Version
    }
}

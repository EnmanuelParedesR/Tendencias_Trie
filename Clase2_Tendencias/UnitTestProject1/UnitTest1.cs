using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Clase2_Tendencias;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReceiveInputArray()
        {
            List<string> Words = new List<string>();
            Words.Add("Marea");
            Words.Add("Marte");
            Words.Add("Mar");
            Words.Add("Mares");

            SpellChecker spellchecker = new SpellChecker(Words);
            CollectionAssert.AreEqual(Words, spellchecker.GetDictionaryWords());
        }

        [TestMethod]
        public void AddSingleLetterWordToTrie()
        {
            List<string> Words = new List<string>();
            Words.Add("I");
            SpellChecker spellchecker = new SpellChecker(Words);
            Trie<string> expected = new Trie<string>();
            expected.Add("0", "I");
            Assert.AreEqual(expected.Find("0"), spellchecker.GetDictionaryNode("0"));
        }

        [TestMethod]
        public void AddMultipleLetterWordToTrie()
        {
            List<string> Words = new List<string>();
            Words.Add("Hello");
            SpellChecker spellchecker = new SpellChecker(Words);
            Trie<string> expected = new Trie<string>();
            string Count = "0";
            foreach (string word in Words)
            {
                foreach (char character in word)
                {
                    expected.Add(Count, character.ToString());
                    Count = Convert.ToString(Convert.ToInt32(Count) + 1);
                }
            }
            Assert.AreEqual(expected.Find("0"), spellchecker.GetDictionaryNode("0"));
        }

        [TestMethod]
        public void AddSingleLetterWordTwoTimesToTrie()
        {
            List<string> Words = new List<string>();
            Words.Add("I");
            Words.Add("Y");
            SpellChecker spellchecker = new SpellChecker(Words);
            Trie<string> expected = new Trie<string>();
            expected.Add("0", "I");
            expected.Add("1", "Y");
            Assert.AreEqual(expected.Find("1"), spellchecker.GetDictionaryNode("1"));
        }

        [TestMethod]
        public void AddMultipleLetterWordTwoTimesToTrie()
        {
            List<string> Words = new List<string>();
            Words.Add("In");
            Words.Add("Ix");
            SpellChecker spellchecker = new SpellChecker(Words);
            Trie<string> expected = new Trie<string>();
            string Count = "0";
            foreach (string word in Words)
            {
                foreach (char character in word)
                {
                    expected.Add(Count, character.ToString());
                    Count = Convert.ToString(Convert.ToInt32(Count) + 1);
                }
            }
            Assert.AreEqual(expected.Find("2"), spellchecker.GetDictionaryNode("2"));
        }

        [TestMethod]
        public void AddMultipleLetterWordMultipleTimesToTrie()
        {
            List<string> Words = new List<string>();
            Words.Add("Marea");
            Words.Add("Marte");
            Words.Add("Mar");
            Words.Add("Mares");
            Words.Add("In");
            Words.Add("Ix");
            SpellChecker spellchecker = new SpellChecker(Words);
            Trie<string> expected = new Trie<string>();
            expected.Add("4", "In");
            expected.Add("5", "Ix");
            expected.Add("0", "Marea");
            expected.Add("1", "Marte");
            expected.Add("2", "Mar");
            expected.Add("3", "Mares");
            Assert.AreEqual(expected.Find("5"), spellchecker.GetDictionaryNode("5"));
        }

        [TestMethod]
        public void FindSingleLetterSimilarWord()
        {
            List<string> Words = new List<string>();
            Words.Add("A");
            Words.Add("B");
            Words.Add("C");
            Words.Add("D");
            SpellChecker spellchecker = new SpellChecker(Words);
            string expected = "B";
            Assert.AreEqual(expected, spellchecker.CheckSpelling("B"));

        }


        [TestMethod]
        public void FindMultipleLetterSimilarWord()
        {
            List<string> Words = new List<string>();
            Words.Add("A");
            Words.Add("Be");
            Words.Add("C");
            
            SpellChecker spellchecker = new SpellChecker(Words);
            string expected = "Be";
            Assert.AreEqual(expected, spellchecker.CheckSpelling("Be"));

        }
    }
}

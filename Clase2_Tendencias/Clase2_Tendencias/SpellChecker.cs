using System;
using System.Collections.Generic;
using System.Text;

namespace Clase2_Tendencias
{
    public class SpellChecker
    {
        private List<string> dictionaryList;
        private Trie<string> dictionaryTrie = new Trie<string>();
        private string Count = "0";

        public SpellChecker(List<string> input)
        {
            dictionaryList = input;
            AddValuesToTrie();
        }

        private void AddValuesToTrie()
        {
            foreach(string word in dictionaryList)
            {
                foreach (char character in word)
                {
                    dictionaryTrie.Add(Count, character.ToString());
                    Count = Convert.ToString(Convert.ToInt32(Count) + 1);
                }
            }
        }


        public List<string> GetDictionaryWords()
        {
            return dictionaryList;
        }

        

        public String GetDictionaryNode(string v)
        {
            return dictionaryTrie.Find(v);
        }

        public string CheckSpelling(string v)
        {
            foreach(var a in dictionaryTrie.root.children)
            {
                if (a.value == v)
                    return a.value;   
            }

            return null;
        }
    }
}

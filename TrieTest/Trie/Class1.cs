﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trie
{
    public class DuplicaKeyExpception : System.Exception { }
    public class KeyWithANumberException : System.Exception { }

    public class Trie<Value>
    {

       private  List<string> SimilarWords = new List<string>();
        class TrieNode
        {
            public string key;
            public Value value;
            public TrieNode[] children = new TrieNode[26];
            public TrieNode(string key = null, Value value = default(Value))
            {
                this.key = key;
                this.value = value;
            }
        }

        TrieNode root = new TrieNode();

        public void Add(string key, Value value)
        {
            if (key == null)
                return;

            if (key.Any(c => char.IsDigit(c)))
                throw new KeyWithANumberException();

            key = key.ToLower();
            TrieNode cur = root;

            foreach (char c in key)
            {
                int idx = c - 'a';
                TrieNode nxt = cur.children[idx];
                if (nxt == null)
                {
                    nxt = new TrieNode();
                    cur.children[idx] = nxt;
                }
                cur = nxt;
            }
            if (cur.key != null)
                throw new DuplicaKeyExpception();
            cur.key = key;
            cur.value = value;
        }

        public string FindAllSimilarWords(string key)
        {
            if (key == null)
                return null;

            
            if (key.Any(c => char.IsDigit(c)))
                throw new KeyWithANumberException();

            key = key.ToLower();
            TrieNode cur = root;
            int count = key.Length;
            foreach (char c in key)
            {
                int idx = c - 'a';
                TrieNode nxt = cur.children[idx];
                if (nxt == null)
                    return null;

                if (count == 1 && FindOneWord(cur.key) != null)
                {
                    SimilarWords.Add(cur.key);
                }
                cur = nxt;
                count--;
            }
            SimilarWords.Add(cur.key);

            foreach (var c in cur.children)                      //Searching all the similars words
            {
                if (c != null)
                    SimilarWords.Add(c.key);
            }
            String a = SimilarWords.ToString();
            
            return SimilarWords.ToString();
        }

        private string FindOneWord(string key)
        {
            if (key == null)
                return null;

            if (key.Any(c => char.IsDigit(c)))
                throw new KeyWithANumberException();
            TrieNode cur = root;
            foreach (char c in key)
            {
                int idx = c - 'a';
                TrieNode nxt = cur.children[idx];
                if (nxt == null)
                    return null;
                cur = nxt;
            }
            return cur.key;
        }

        public override string ToString()  //This isn't working, i don't know why.
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < SimilarWords.Count; i++)
            {
                
                sb.Append(SimilarWords[i] + " ");
            }
            return sb.ToString();
        }



    }

}
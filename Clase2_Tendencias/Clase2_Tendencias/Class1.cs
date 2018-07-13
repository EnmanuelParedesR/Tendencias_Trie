using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using VDS.Common.Tries;

namespace Clase2_Tendencias
{
    public class DuplicaKeyExpception : System.Exception { }

    public class Trie<Value>
    {
        public class TrieNode
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

        public TrieNode root = new TrieNode();

        public void Add(string key, Value value)
        {
            TrieNode cur = root;
            foreach (char c in key)
            {
                int idx = c - 48;
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

        public Value Find(string key)
        {
            TrieNode cur = root;
            foreach (char c in key)
            {
                int idx = c - 48;
                TrieNode nxt = cur.children[idx];
                if (nxt == null)
                    return default(Value);
                cur = nxt;
            }
            return cur.value;
        }

        public Value Remove(string key)
        {
            TrieNode cur = root;
            foreach (char c in key)
            {
                int idx = c - 48;
                TrieNode nxt = cur.children[idx];
                if (nxt == null)
                    throw new KeyNotFoundException();
                cur = nxt;
            }
            if (cur.key == null)
                throw new KeyNotFoundException();
            Value ret = cur.value;
            cur.key = null;
            cur.value = default(Value);
            return ret;
        }
    }
}




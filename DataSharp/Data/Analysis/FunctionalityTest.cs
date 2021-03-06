﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSharp.Data.Analysis
{
    public static class FunctionalityTest
    {
        /// <summary>
        /// Test whether the string with same content will have the same hash code.
        /// </summary>
        public static void StringHashTest()
        {
            string s1 = "123";
            Console.WriteLine("s1 = \"{0}\"", s1);
            Console.Write("Please enter \"123\": ");
            string s2 = Console.ReadLine();
            Console.WriteLine("s2 = \"{0}\"", s2);
            Console.WriteLine("s1.GetHashCode() == s2.GetHashCode() : {0}", s1.GetHashCode() == s2.GetHashCode());
        }

        /// <summary>
        /// This function is used to count the frequency of occurance of each object.
        /// </summary>
        public static void FrequencyCounter()
        {
            string[] strings = { "123", "456", "789", "111", "222", "333" };
            SortedSet<string>[] sets = new SortedSet<string>[3];
            for (int i = 0; i < sets.Length; i++)
                sets[i] = new SortedSet<string>(strings);

            Dictionary<string, int> frequency = new Dictionary<string, int>();
            foreach (SortedSet<string> set in sets)
            {
                foreach (string s in set)
                {
                    if (!frequency.ContainsKey(s))
                        frequency[s] = 1;
                    else
                        frequency[s]++;
                }
            }

            foreach (KeyValuePair<string, int> kvp in frequency)
                Console.WriteLine(kvp);
        }

        /// <summary>
        /// This method tries to find a way to update Value in Dictionary&lt;TKey, TValue> when traverse through it.
        /// </summary>
        public static void DictionaryUpdateDemo()
        {
            string[] strings = { "123", "456", "789", "111", "222", "333" };
            SortedSet<string>[] sets = new SortedSet<string>[3];
            for (int i = 0; i < sets.Length; i++)
                sets[i] = new SortedSet<string>(strings);

            Dictionary<string, int> frequency = new Dictionary<string, int>();
            foreach (SortedSet<string> set in sets)
            {
                foreach (string s in set)
                {
                    if (!frequency.ContainsKey(s))
                        frequency[s] = 1;
                    else
                        frequency[s]++;
                }
            }

            string[] subset = { "123", "456", "789" };

            KeyValuePair<string, int>[] kvps = frequency.ToArray();
            for (int i = 0; i < kvps.Length; i++)
            {
                string key = kvps[i].Key;
                foreach (string s in subset)
                {
                    if (key.Equals(s))
                        frequency[key]++;
                }
            }

            foreach (KeyValuePair<string, int> kvp in frequency)
                Console.WriteLine(kvp);
        }
    }
}
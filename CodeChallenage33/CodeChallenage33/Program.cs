using System;
using System.Collections.Generic;

namespace CodeChallenage33
{
    public class Program
    {
        public static List<List<string>> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<List<string>> result = new List<List<string>>();

            foreach (var kvp in synonyms)
            {
                string key = kvp.Key;
                string synonym = kvp.Value;

                string antonym = antonyms.ContainsKey(key) ? antonyms[key] : null;

                result.Add(new List<string> { key, synonym, antonym });
            }

            return result;
        }

        public static void Main()
        {
            // Test case 1
            Dictionary<string, string> synonyms1 = new Dictionary<string, string>
            {
                { "diligent", "employed" },
                { "fond", "enamored" },
                { "guide", "usher" },
                { "outfit", "garb" },
                { "wrath", "anger" }
            };

            Dictionary<string, string> antonyms1 = new Dictionary<string, string>
            {
                { "diligent", "idle" },
                { "fond", "averse" },
                { "guide", "follow" },
                { "flow", "jam" },
                { "wrath", "delight" }
            };

            List<List<string>> result1 = LeftJoin(synonyms1, antonyms1);
            PrintResult(result1);

            // Test case 2 (empty dictionaries)
            Dictionary<string, string> synonyms2 = new Dictionary<string, string>();
            Dictionary<string, string> antonyms2 = new Dictionary<string, string>();

            List<List<string>> result2 = LeftJoin(synonyms2, antonyms2);
            PrintResult(result2);
        }

        public static void PrintResult(List<List<string>> result)
        {
            foreach (var row in result)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }
        }
    }
}

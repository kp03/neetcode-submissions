public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> anagrams =
            new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] characters = str.ToCharArray();
            Array.Sort(characters);
            string key = new string(characters);
            if (!anagrams.ContainsKey(key)) {
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(str);
        }

        return anagrams.Values.ToList();
    }
}
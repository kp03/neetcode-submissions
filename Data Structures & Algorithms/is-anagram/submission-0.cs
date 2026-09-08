public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> frequency = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (!frequency.ContainsKey(s[i])) {
                frequency[s[i]] = 1;
            } else {
                frequency[s[i]] = frequency[s[i]] + 1;
            }
        }

        for (int i = 0; i < t.Length; i++) {
            if (frequency.ContainsKey(t[i])) {
                frequency[t[i]] = frequency[t[i]] - 1;
                if (frequency[t[i]] == 0) {
                    frequency.Remove(t[i]);
                }
            }
        }

        return frequency.Count == 0;

    }
}

public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";
        foreach (string str in strs) {
            int strLength = str.Length;
            string newEncodedPart = strLength.ToString() + "#" + str;
            encodedString = encodedString + newEncodedPart;
        }

        return encodedString;
    }

    public List<string> Decode(string s) 
    {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length) 
        {
            // Find the index of the next '#' starting from position i
            int delimiterIndex = s.IndexOf('#', i);
            
            // Parse the length preceding the '#'
            int length = int.Parse(s.Substring(i, delimiterIndex - i));
            
            // Move index past the '#' character
            i = delimiterIndex + 1;
            
            // Extract the string of the given length
            string str = s.Substring(i, length);
            result.Add(str);
            
            // Advance index past the extracted string
            i += length;
        }

        return result;
    }
}

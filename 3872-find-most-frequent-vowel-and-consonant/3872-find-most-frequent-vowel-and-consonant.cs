public class Solution {
    public int MaxFreqSum(string s) {
        Dictionary<char, int> Vowel_count = new Dictionary<char, int>();
        Dictionary<char, int> Others_count = new Dictionary<char, int>();
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        foreach (char letter in s) 
        {
            if (vowels.Contains(letter))
            {
                if (Vowel_count.ContainsKey(letter))
                    Vowel_count[letter]++;
                else
                    Vowel_count[letter] = 1;
            }
            else
            {
                if (Others_count.ContainsKey(letter))
                    Others_count[letter]++;
                else
                    Others_count[letter] = 1;
            }
        }
 return (Vowel_count.Count > 0 ? Vowel_count.Values.Max() : 0)+(Others_count.Count > 0 ? Others_count.Values.Max() : 0) ;
     
    }
}
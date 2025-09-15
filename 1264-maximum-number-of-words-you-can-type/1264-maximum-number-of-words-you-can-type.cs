public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int count=0;
        string[] txt=text.Split(' ');
        HashSet<char> letters=new HashSet<char>(brokenLetters);
        foreach(string word in txt){
            bool cantype= true;
            foreach(char c in letters)
            {
                if(word.Contains(c)){
                     cantype =false;
                    break;
                }
            }
            if(!cantype) count++;
        }
        return txt.Length-count;
    }
}
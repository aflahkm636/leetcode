public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char>letters=new HashSet<char>(allowed);
int count=0;
        foreach(string word in words){
            int flag=0;
            foreach(char c in word){
               if(!letters.Contains(c)) {
                flag=1;
                break;
               }
             
            } if(flag==0) {count++;}
        }
        return count;
    }
}
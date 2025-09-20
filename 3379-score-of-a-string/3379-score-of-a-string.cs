public class Solution {
    public int ScoreOfString(string s) {
       int a = 0;
    for( int i=0;i<s.Length-1;i++){
        a +=Math.Abs(s[i]-s[i+1]);
    }
   return a;
    }
}
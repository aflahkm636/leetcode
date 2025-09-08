public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int a=n/2;
        int b=n-a;
        
        while(a.ToString().Contains("0") ||b.ToString().Contains("0") )
        {
            a=a-7;
            b=b+7;
        }
  return new int[] { a, b };    }
}
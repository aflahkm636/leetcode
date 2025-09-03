public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
            int count=0;
            int m=jewels.Length;
            int n=stones.Length;
        for(int i=0;i<=m-1;i++){
            for(int j=0;j<=n-1;j++)
            {
            if(jewels[i]==stones[j]){
                count++;
            }
            }
        }
        return count;
    }
}
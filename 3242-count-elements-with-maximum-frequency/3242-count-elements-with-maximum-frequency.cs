public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int,int> hashnum=new Dictionary<int,int>();
        int maxCount=0;
        int maxfreq=0;
        foreach(int i in nums){
            if(hashnum.ContainsKey(i)){
                hashnum[i]++;
            }else{
                hashnum[i]=1;
                
            }
            int freq=hashnum[i];
           if(freq>maxfreq){
            maxfreq=freq;
            maxCount=1;
           }else if(freq==maxfreq){
            maxCount++;
           }
        }
       
            return maxfreq*maxCount;
    }
}
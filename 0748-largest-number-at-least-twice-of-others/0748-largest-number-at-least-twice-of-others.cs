public class Solution {
    public int DominantIndex(int[] nums) {
     int max=nums.Max();
     int index=Array.IndexOf(nums,max);
     bool flag=true;
     for(int i=0;i<=nums.Length-1;i++){
        if(nums[i]==max) continue;
        if(nums[i]*2>max) flag=false;

     }
 return flag==true? index:-1;
    }
}
public class Solution {
    public int SingleNumber(int[] nums) {
      int output=0;
      foreach(int num in nums){
        output=output^num;
      }  
      return output;
}
}
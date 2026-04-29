public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;
        foreach(int num in nums)
        {
            if(num < min)
                min = num;
        }
        return min;
    }
}

public class Solution {
    public int FindDuplicate(int[] nums) {
        var counts = new HashSet<int>(nums.Length);
        foreach(var num in nums)
        {
            if(!counts.Add(num))
            {
                return num;
            }
        }
        return 0;
    }
}

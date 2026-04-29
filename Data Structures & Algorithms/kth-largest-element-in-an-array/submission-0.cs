public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var items = new PriorityQueue<int,int>(nums.Length);
        foreach(int num in nums)
        {
            items.Enqueue(num,-num);
        }

        while(k>1)
        {
            items.Dequeue();
            k--;
        }
        return items.Peek();
    }
}
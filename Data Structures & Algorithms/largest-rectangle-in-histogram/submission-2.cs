public class Solution {
    public int LargestRectangleArea(int[] heights) {
            if (heights.Length == 1)
    {
        return heights[0] * 1;
    }
    int maxArea = int.MinValue;
    for (int i = 0; i < heights.Length; i++)
    {
        var bars = new List<int>(heights.Length);
        for (int j = i; j < heights.Length; j++)
        {
            bars.Add(heights[j]);
            int shorterBar = bars.Min();
            maxArea = Math.Max(maxArea, (j - i + 1) * shorterBar);
        }
    }
    return maxArea;
    }
}
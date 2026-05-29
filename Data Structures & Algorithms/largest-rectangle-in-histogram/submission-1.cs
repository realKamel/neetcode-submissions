public class Solution {
    public int LargestRectangleArea(int[] heights) {
            if (heights.Length == 1)
    {
        return heights[0] * 1;
    }
    int maxArea = int.MinValue;

    var stack = new Stack<(int value, int index)>(heights.Length);

    for (int i = 0; i < heights.Length; i++)
    {
        if (!stack.TryPeek(out var tof) || tof.value <= heights[i])
        {
            stack.Push((heights[i], i));
        }
        else
        {
            var lastPoppedIndex = 0;
            while (stack.TryPeek(out var entry) && entry.value > heights[i])
            {
                lastPoppedIndex = stack.Pop().index;
                maxArea = Math
                .Max(maxArea, entry.value * (i - entry.index));
            }
            stack.Push((heights[i], lastPoppedIndex));
        }
    }
    while (stack.TryPeek(out var entry))
    {
        stack.Pop();
        maxArea = Math.Max(maxArea, entry.value * (heights.Length - entry.index));
    }
    return maxArea;
    }
}

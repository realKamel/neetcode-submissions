public class Solution {
    public int MaxProfit(int[] prices) {
            var maxProfit = 0;
    for (var i = 0; i < prices.Length; i++)
    {
        for (var j = i + 1; j < prices.Length; j++)
        {
            maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);
        }
    }
    return maxProfit;
    }
}

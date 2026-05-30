public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 1) {
            return 0;
        }

        var maxProfit = 0;
        var buy = 0;
        var sell = 1;
        while (sell < prices.Length) {
            if (prices[buy] > prices[sell]) {
                buy = sell;
                sell = buy + 1;
                continue;
            }
            maxProfit = Math.Max(maxProfit, prices[sell] - prices[buy]);
            sell++;
        }
        return maxProfit;
    }
}
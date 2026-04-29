public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int rateCandidate = piles.Max();
        int low = 1, high = rateCandidate;

        while (low <= high)
        {
            int rate = (low + high) / 2;

            int currentConsumedHours = piles
            .Aggregate(0,(accumulator, currentValue) =>
                          accumulator + (int)Math.Ceiling((double)currentValue / rate));

            if (currentConsumedHours <= h)
            {
                rateCandidate = Math.Min(rateCandidate,rate);
                high = rate - 1;
            }
            else
            {
                low = rate + 1;
            }
        }
        return rateCandidate;
    }
}

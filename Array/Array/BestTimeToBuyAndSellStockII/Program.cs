public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int ans = 0;
        for (int i = prices.Length - 1; i >= 1; i--)
        {
            if (prices[i] - prices[i - 1] > 0) ans += prices[i] - prices[i - 1];
        }

        return ans;
    }
}
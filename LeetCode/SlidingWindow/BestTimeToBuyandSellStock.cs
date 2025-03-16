using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    public class BestTimeToBuyandSellStock
    {
        public int Execute(int[] prices)
        {
            // Set the max profit to 0
            int maxProfit = 0;

            // Set the min price to the maximum value of an integer
            int minPrice = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                // If the current price is less than the min price, set the min price to the current price, because we want to buy at the lowest price
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                // If the current price is greater than the min price, calculate the profit and set the max profit to the maximum of the current max profit and the calculated profit
                else
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                }
            }

            // Return the max profit
            return maxProfit;
        }
    }
}

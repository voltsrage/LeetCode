using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    public class BestTimeToBuyandSellStock
    {
        /// <summary>
        /// The logic is to find the maximum profit that can be made by buying and selling a stock
        /// We will keep track of the minimum price and the maximum profit
        /// We will iterate through the prices array
        /// If the current price is less than the minimum price, we will update the minimum price
        /// If the current price is greater than the minimum price, we will calculate the profit and update the maximum profit
        /// We will return the maximum profit
        /// The time complexity is O(n), where n is the length of the prices array
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
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

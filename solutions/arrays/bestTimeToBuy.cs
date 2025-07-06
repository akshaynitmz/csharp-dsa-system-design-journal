 int MaxProfit(int[] prices) 
{
    int b = prices[0]; // Lowest price so far (buy)
    int p = 0;         // Max profit

    for (int i = 1; i < prices.Length; i++) 
    {
        // Update max profit if selling today is better
        if (p < prices[i] - b)
            p = prices[i] - b;

        // Update buy price if today's price is lower
        if (b > prices[i])
            b = prices[i];
    }

    return p;
}

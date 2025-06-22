class TwoSum
{
   
   public static int[] TwoSum(int[] nums, int target)
{
    // Dictionary to store value → index mapping
    Dictionary<int, int> map = new Dictionary<int, int>();

    // Traverse the array once (O(n) time)
    for (int i = 0; i < nums.Length; i++)
    {
        // Calculate the complement we need to reach the target
        int c = target - nums[i];

        // If the complement is already in the map, we found the pair
        if (map.ContainsKey(c))
            return new int[] { map[c], i };

        // Otherwise, store the current value with its index
        // So we can find it later as a complement
        map[nums[i]] = i;
    }

    // If no pair found, return null (input guarantees one solution)
    return null;
}

 }
 

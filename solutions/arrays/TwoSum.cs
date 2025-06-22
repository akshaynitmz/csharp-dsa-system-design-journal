class TwoSum
{
   
    public static int[] TwoSum(int[] nums, int target) {

       Dictionary<int, int> map = new Dictionary<int, int>();
      for(int i=0;i<nums.Length;i++)
        {
          int c = target - nums[i];
          if (map.ContainsKey(c))
              return new int[] { map[c], i };
          else
             map[nums[i]] = i;
         }
       return null;
    }
 }
 

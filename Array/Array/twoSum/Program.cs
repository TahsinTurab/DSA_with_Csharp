public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();
        var ans = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.ContainsKey(target - nums[i]))
            {
                ans[0] = i;
                ans[1] = seen[target - nums[i]];
                return ans;
            }
            seen[nums[i]] = i;
        }
        return ans;
    }
}
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        if (nums.Length == 1) return nums[0];
        if (nums[0] != nums[1]) return nums[0];
        if (nums[nums.Length - 1] != nums[nums.Length - 2]) return nums[nums.Length - 1];
        int res = -1;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
            {
                res = nums[i];
                break;
            }
        }
        return res;
    }
}
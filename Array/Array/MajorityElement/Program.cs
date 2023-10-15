public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int n = nums.Length;
        int crntFreq = 1, res = 0;
        Array.Sort(nums);
        for (int i = 1; i < n; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                crntFreq++;
            }
            else
            {
                if (crntFreq > n / 2) res = nums[i - 1];
                crntFreq = 1;
            }
        }
        if (crntFreq > n / 2) res = nums[n - 1];
        return res;
    }
}
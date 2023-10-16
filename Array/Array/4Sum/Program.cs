public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var ans = new List<IList<int>>();
        Array.Sort(nums);

        for (int k = 0; k < nums.Length; k++)
        {
            long target1 = target - nums[k];
            for (int i = k + 1; i < nums.Length; i++)
            {
                long target2 = target1 - nums[i];
                int l = i + 1, r = nums.Length - 1;

                while (l < r)
                {
                    if (nums[l] + nums[r] == target2)
                    {
                        var tempList = new List<int>() { nums[k], nums[i], nums[l], nums[r] };
                        ans.Add(tempList);
                        l++;
                        r--;
                        while (l < r)
                        {
                            if (nums[l] == nums[l - 1]) l++;
                            else break;
                        }
                        while (l < r)
                        {
                            if (nums[r] == nums[r + 1]) r--;
                            else break;
                        }
                    }
                    else if (nums[l] + nums[r] < target2) l++;
                    else r--;
                }

                while (i < r)
                {
                    if (nums[i] == nums[i + 1]) i++;
                    else break;
                }

            }

            while (k < nums.Length - 1)
            {
                if (nums[k] == nums[k + 1]) k++;
                else break;
            }
        }

        return ans;
    }
}
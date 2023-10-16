public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int target = -nums[i];
            int l = i + 1, r = nums.Length - 1;

            while (l < r)
            {
                if (nums[l] + nums[r] == target)
                {
                    IList<int> tempList = new List<int>() { nums[i], nums[l], nums[r] };
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
                else if (nums[l] + nums[r] < target) l++;
                else r--;
            }

            while (i < r)
            {
                if (nums[i] == nums[i + 1]) i++;
                else break;
            }

        }

        return ans;
    }
}
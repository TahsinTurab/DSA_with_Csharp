public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int z = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && z == -1)
            {
                z = i;
            }
            else if (nums[i] != 0 && z != -1)
            {
                int temp = nums[i];
                nums[i] = nums[z];
                nums[z] = temp;
                z++;
            }
        }
    }
}
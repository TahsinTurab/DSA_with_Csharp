public void Merge(int[] nums1, int m, int[] nums2, int n)
{

    int x = m - 1, y = n - 1, i = m + n - 1;
    while (x >= 0 && y >= 0)
    {
        if (nums1[x] > nums2[y])
        {
            nums1[i] = nums1[x];
            x--;
        }
        else
        {
            nums1[i] = nums2[y];
            y--;
        }
        i--;
    }
    while (y >= 0 && i >= 0)
    {
        nums1[i] = nums2[y];
        y--;
        i--;
    }
}
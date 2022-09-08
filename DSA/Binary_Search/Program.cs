var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


Console.Write("Enter the element: ");
int n = int.Parse(Console.ReadLine());

int l = 0, r = a.Length - 1,pos=-1;
while (l <= r)
{
    int mid = l + (r - l) / 2;
    if (a[mid] == n)
    {
        pos = mid;
        break;
    }
    else if (a[mid] < n)
    {
        l = mid + 1;
    }
    else r = mid - 1;
}

if (pos == -1) Console.WriteLine("Not found");
else Console.WriteLine($"found at position {pos}");
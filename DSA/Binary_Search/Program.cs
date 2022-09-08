using System.Diagnostics;

var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


Console.Write("Enter the element: ");
int n = int.Parse(Console.ReadLine());
var sw = new Stopwatch();
int l = 0, r = a.Length - 1,pos=-1;
sw.Start();
while (l <= r)
{
    int mid = l + (r - l) / 2;
    if (a[mid] == n)
    {
        pos = mid;
        sw.Stop();
        break;
    }
    else if (a[mid] < n)
    {
        l = mid + 1;
    }
    else r = mid - 1;
}
sw.Stop();
if (pos == -1) Console.WriteLine("Not found");
else Console.WriteLine($"found at position {pos}");

Console.WriteLine($"Time: {sw.Elapsed:s\\.fffffff}");
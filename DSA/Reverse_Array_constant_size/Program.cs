var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n=a.Length;
for(int i = 0; i <= n/2; i++)
{
    int temp = a[i];
    a[i] = a[n - i];
}

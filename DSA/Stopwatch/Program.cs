using System.Diagnostics;

var sw = new Stopwatch();
sw.Start();
int j = 0;
for(int i = 0; i < 100000000; i++)
{
    j++;
}
sw.Stop();
Console.WriteLine(j);
Console.WriteLine($"Time: {sw.Elapsed:s\\.fffffff}");

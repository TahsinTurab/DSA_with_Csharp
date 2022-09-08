int[] number = new int[10];
var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
number = a;

//for(int i = 0; i < number.Length; i++)
//{
//    Console.WriteLine(number[i]);
//}

int n = int.Parse(Console.ReadLine());
//Console.WriteLine(n);


//Find index of n in array a
int index = Array.IndexOf(a, n);
if(index>=0 && index<number.Length)
    Console.WriteLine(index);
else Console.WriteLine("Not found");
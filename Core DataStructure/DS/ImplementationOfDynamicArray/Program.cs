using ImplementationOfDynamicArray;

var v = new vector<int>();
Console.WriteLine($"vector size {v.size}");
v.push_back(1);
v.push_back(2);
v.push_back(3);
Console.WriteLine($"vector size {v.size}");
v.print();
v.pop_back();
Console.WriteLine($"vector size {v.size}");
v.print();



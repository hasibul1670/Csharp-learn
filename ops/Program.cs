//int a = 35;
//int b = 120;
//int c = 215;

//if(a> b && a >c)
//{
//    Console.WriteLine($"a is the largest: {a}");
//}
//else if (b>  a && b >c)
//{
//    Console.WriteLine($"b is the largest: {b}");
//}
//else
//{
//    Console.WriteLine($"c is the largest: {c}");
//}

int a = 3;
int b = 4;
int c = 2;

int max = Math.Max(a, Math.Max(b, c));
int Min = Math.Min(a, Math.Min(b, c));


Console.WriteLine($"The largest number is: {max}");
Console.WriteLine($"The smallest number is: {Min++}");

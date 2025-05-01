int i = 10;

while(i<=5){
    System.Console.WriteLine("Hi" + i);
    i++;
}
do {
    System.Console.WriteLine("do-while --> Hi" + i);
}while(i<=5);
for (int i = 0; i < 10; i++)
{
    if(i==5){
        // break;
        continue;
    }
    System.Console.WriteLine(i);
}


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine($"i:{i} --> j{j}");
    }
}

class Test
{

    public static void addSum(int a, int b)
    {
        System.Console.WriteLine($"Sum:  {a + b}");
    }
    public static string Hello()
    {
       
        return "Hello World";
    }

    public static void Main(string[] args)
    {
        addSum(10,20);
        addSum(50,20);
        addSum(20,20);
        Hello();
    }
}
class HelloApp
{
    static void Main(string[] args)
    {
      string username  = Console.ReadLine();
      int Roll = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Name " + username);
        Console.WriteLine("Role " + Roll);

    }
}
//Implicit /Automatic Type Conversion
//Implicit type conversion is done by the compiler automatically.
//Example: int to double
//char -> int -> long-> float -> double



//Explicit Type Conversion
//double-> float->int->char

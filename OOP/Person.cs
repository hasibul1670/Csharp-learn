public class Person
{
    //variable
    public String name;
    public int age;
    // methods 
    public void setValue(string n, int a)
    {
        name = n;
        age = a;
    }
    public void DisplayPerson()
    {
        System.Console.WriteLine($"{name}--- {age}");
    }

}
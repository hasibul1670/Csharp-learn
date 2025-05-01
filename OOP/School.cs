public class School{
    string name;
    int estd;

    // class name == method name called constructor
    // use  for get and set value in run time
    public School(){
        System.Console.WriteLine("Default Constructor------>");
    }

      public School(string n,int e){
        System.Console.WriteLine("Default Constructor");
        System.Console.WriteLine($"{n}---> {e}");

    }

    // when pass any parameter then it is called parametrized constructor

}
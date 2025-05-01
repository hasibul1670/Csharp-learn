
Console.WriteLine("Learn OOP!");

// Person p1= new Person();

// p1.setValue("hasibu",22);
// p1.DisplayPerson();

// Person p2= new Person();
// p2.setValue("suraas",12);
// p2.DisplayPerson();


// when create an obj , constructor call automatically, no nned to call constructor again.
School s1 = new School();
s1.name = "hasib0909";
s1.Display("hasib",1887);


School s2 = new School();
s2.Display("luka",1222);

System.Console.WriteLine(s1.name);
s1=s2;
s2.name = "SSS";
System.Console.WriteLine(s1.name);
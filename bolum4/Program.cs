// string name ="Efe";
// string surname ="Doğan";
// int age = 24;

// String str = "My name is " +name +" "+surname +" and I'm " +age+ " years old.";

// String str = string.Format("My name is {0} {1} and I'm {3} years old.",name,surname,age);

// string str = $"My name is {name} {surname} and I'm {age} years old.";

// Console.WriteLine(str);



Console.Write("Name: ");
string name=Console.ReadLine();

Console.Write("Surname: ");
string surname = Console.ReadLine();

Console.Write("Age: ");
int age = int.Parse(Console.ReadLine());

String str = $"My name is {name} {surname} and I'm {age} years old.";

Console.WriteLine(str);
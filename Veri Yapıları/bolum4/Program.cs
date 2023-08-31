Console.Write("name: ");
string name=Console.ReadLine();
           
Console.Write("surname: ");
string surname = Console.ReadLine();

Console.Write("age: ");
int age = int.Parse(Console.ReadLine());

// string str = "My name is "+ name + " and I'm "+ age + "years old.";
// string str = string.Format("My name is {0} {1} and I'm {2} years old.",name,surname,age);

string str = $"My name is {name} {surname} and I'm {age} years old.";
            
            
Console.WriteLine(str);

using Maths;
using HR;
using GDI;

Person person1 = new Person();
person1.Name = "Ravi";
person1.Age = 48;
person1.Id = 23;

Person person2 = new Person(56,"Sachin", 23);
 

Console.WriteLine(person1);
Console.WriteLine(person2);
Console.WriteLine("Hello, World!");

var c1 = new Complex(67, 34);
var c2 = new Complex(12, 33);
var c3 = c1 + c2;
var c4 = c1 - c2;

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);

Point p1 = new Point(34, 45);

Point p2 = new Point(77, 56);


Line l = new Line(p1,p2, 3, "dash", "red");
Shape shape = l;
shape.Draw();


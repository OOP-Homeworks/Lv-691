// See https://aka.ms/new-console-template for more information

using MalaOks_HW9;

List<Shape> shapes = new();
shapes.Add(new Circle(3, nameof(Circle)));
shapes.Add(new Square(1, nameof(Square)));
shapes.Add(new Circle(5, nameof(Circle)));
shapes.Add(new Square(6, nameof(Square)));
shapes.Add(new Circle(7, nameof(Circle)));
shapes.Add(new Square(8, nameof(Square)));
foreach (Shape shape in shapes)
{
    shape.GetArea();
    shape.GetPerimeter();
}
Console.WriteLine("Sourse:");
foreach (var item in shapes)
{
    Console.WriteLine(item.Name + " " + item.Perimeter);
}
//перевіряю на класичному Linq
//var qwr = from shape in shapes
//          where shape.Area > 10 && shape.Area < 100
//          select shape; 
var qwr = shapes.Where(n => n.Area > 10 && n.Area < 100);
foreach (var item in qwr)
{
    Console.WriteLine(item.Area);
    using (StreamWriter sw = new(@"D:\Area.txt", true, System.Text.Encoding.Default))
    {
        sw.WriteLine(item.Area);
    }
}

var qwrNm = shapes.Where(n => n.Name.ToLower().Contains("a"));
foreach (var item in qwrNm)
{
    Console.WriteLine(item.Name);
    using (StreamWriter sw = new(@"D:\NameContainA.txt", true, System.Text.Encoding.Default))
    {
        sw.WriteLine(item.Name);
    }
}

Console.WriteLine("\n" + "Remove:");
shapes.RemoveAll(n => n.Perimeter < 5);
foreach (var item in shapes)
{
    Console.WriteLine(item.Name + " " + item.Perimeter);
}
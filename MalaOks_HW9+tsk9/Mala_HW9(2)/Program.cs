// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

List<string> lst = new();
string temp = String.Empty;
using (StreamReader sr = new(@"D:\111.txt", System.Text.Encoding.Default))
{
    while ((temp = sr.ReadLine())!= null)
    {
        lst.Add(temp);
    }
}
Console.WriteLine(lst.Count);
Regex rgx = new(@"\W");
MatchCollection mtc;
foreach (var item in lst)
{
    mtc = rgx.Matches(item);
    if (mtc.Count != 0)
    {
        Console.WriteLine(mtc.Count);
    }
}

Console.WriteLine("Max: " + lst.Max());
Console.WriteLine("Min: " + lst.Min());
Console.WriteLine("Lines containes 'var':");
var qwr = lst.Where(n => n.Contains("var"));
foreach (var item in qwr)
{
    Console.WriteLine(item);
}
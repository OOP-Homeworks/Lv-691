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
//List<int> count = new();
MatchCollection mtc; //= rgx.Matches();
foreach (var item in lst)
{
    mtc = rgx.Matches(item);
    if (mtc.Count != 0)
    {
        //count.Add(mtc.Count);
        Console.WriteLine(mtc.Count);
    }
}

//var qwr = lst.Where(n => n);
// See https://aka.ms/new-console-template for more information

using MalaOks_tsk8;

List<Person> prsns = new();
prsns.Add(new Staff("Marie", "Curie", 2000));
prsns.Add(new Staff("Johnnie", "Depp", 1000));
prsns.Add(new Teacher("Johnnie", "Walker", "ethics", 700));
prsns.Add(new Developer("Jeffrey", "Richter", "wizard", 1200));
prsns.Add(new Teacher("Ernest", "Hemingway", "literature", 900));
foreach (var item in prsns)
{
    item.Print();
}
Console.WriteLine($"\nEnter person's name");
string prsName = Console.ReadLine().ToLower();

bool fnd = false;
foreach (var item in prsns)
{
    if (item.Name.Substring(0, item.Name.IndexOf(" ")).ToLower() == prsName)
    {
        item.Print();
        fnd = true;
    }
}
if (fnd == false)
{
    Console.WriteLine($"Searched name {prsName} not found");
}
Console.WriteLine($"\nSorted collection by names in file 'SortedCollectPeople.txt'");
prsns.Sort();
string path = @"D:\SortedCollectPeople.txt";
using (StreamWriter sw = new(path, false))
{
    sw.WriteLine("Sorted collection by names");
    foreach (var item in prsns)
    {
        sw.WriteLine(item.Name.Substring(0, item.Name.IndexOf(" ")) + " " + item.SurName);
    }
}
Console.WriteLine($"\nStaff collection - original version");
List<Staff> empl = new();
foreach (Staff item in prsns)
{
    if (item.GetType() == typeof(Developer))
    {
        empl.Add(item);
    }
    if (item.GetType() == typeof(Teacher))
    {
        empl.Add(item);
    }
}
foreach (var item in empl)
{
    item.Print();
}
empl.Sort();
Console.WriteLine($"\nSorted collection of staff by salary");
foreach (var item in empl)
{
    item.Print();
}

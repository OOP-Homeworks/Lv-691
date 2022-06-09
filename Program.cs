using System;
using System.IO;
using System.Xml.Serialization;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person per = new Person("Richard", new DateTime(2006,10,23));
            XmlSerializer xmlser = new XmlSerializer(typeof(Person));
            Stream serialStream = new FileStream("person.xml", FileMode.Create);
            xmlser.Serialize(serialStream, per);
            serialStream.Close();


            serialStream = new FileStream("person.xml", FileMode.Open);
            Person per2 = xmlser.Deserialize(serialStream) as Person;
            Console.WriteLine(per2.ToString());
        }
    }
}

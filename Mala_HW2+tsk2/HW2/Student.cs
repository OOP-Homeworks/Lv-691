using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal struct Student
    {
        public Student(string lstName, string grpNum)
        {
            lastName = lstName;
            groupNumber = grpNum;
        }
        public string lastName;
        public string groupNumber;
        //public List<Student> lstStd = new();        
    }

    internal class ListStudent
    {
        public List<Student> lstStd = new();
        public ListStudent()
        {
            Student depp = new("Depp", "11");
            Student prat = new("Prat", "11");
            Student joly = new("Jolly", "11");

            Student lou = new("Lou", "17");
            Student evans = new("Evans", "17");
            Student pattison = new("Pattison", "17");
            Student pitt = new("Pitt", "17");
            Student pen = new("Pen", "17");

            lstStd.Add(depp);
            lstStd.Add(prat);
            lstStd.Add(joly);

            lstStd.Add(lou);
            lstStd.Add(evans);
            lstStd.Add(pattison);
            lstStd.Add(pitt);
            lstStd.Add(pen);
        }        
        public void ListStudentByGroupNumber( string grpNum)
        {
            foreach (var item in lstStd)
            {
                if (item.groupNumber == grpNum)
                {
                    Console.WriteLine($"Student Last name: {item.lastName} and Student group number: {item.groupNumber}");
                }
            }
        }

        public void FindStudentByGrpNumLastName(string grpNum, string ltr)
        {
            foreach (var item in lstStd)
            {
                if (item.groupNumber == grpNum && item.lastName.StartsWith(ltr.ToUpper()))
                {
                    Console.WriteLine($"Student Last name: {item.lastName} and Student group number: {item.groupNumber}");
                }
            }
        }


        
        


    }

    
}

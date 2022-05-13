using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal struct DogStruct
    {

        public string Name;
        public string Mark;
        public string Age;
        public override string ToString()
        {
            return string.Format($"Dog name: {Name},dog mark: {Mark}, dog age: {Age}");
        }
    }
}

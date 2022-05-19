using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework5
{
    internal interface IDeveloper
    {
        string Tool { get; set; }
        void Creat();
        void Destroy();
    }
}

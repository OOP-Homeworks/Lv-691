using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_HW5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        public void Create();
        public void Destroy();
    }
}

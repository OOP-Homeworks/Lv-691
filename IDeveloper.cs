using System;
using System.Collections.Generic;
using System.Text;

namespace hw5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
            
    }
}

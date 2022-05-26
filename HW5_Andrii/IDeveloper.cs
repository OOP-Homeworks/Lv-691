using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Andrii
{
    public interface IDeveloper
    {
        string Tool { get; set; }
        public void Create();
        public void Destroy();
    }
}

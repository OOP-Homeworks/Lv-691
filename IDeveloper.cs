using System;
namespace Homework_5
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }

}

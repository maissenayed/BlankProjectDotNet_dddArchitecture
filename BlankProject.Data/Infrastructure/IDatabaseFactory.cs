using System;

namespace BlankProject.Data.Infrastructure
{
    public interface IDatabaseFactory:IDisposable
    {
        MyContext MyContext { get; }
    }
}

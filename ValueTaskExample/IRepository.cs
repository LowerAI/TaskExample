using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ValueTaskExample
{
    public interface IRepository<T>
    {
        ValueTask<T> GetData();

        ValueTask<T> GetDataAsync();
    }
}

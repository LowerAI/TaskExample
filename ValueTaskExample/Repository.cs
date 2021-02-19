using System.Threading.Tasks;

namespace ValueTaskExample
{
    public class Repository<T> : IRepository<T>
    {
        public ValueTask<T> GetData()
        {
            var value = default(T);
            return new ValueTask<T>(value);
        }

        public async ValueTask<T> GetDataAsync()
        {
            var value = default(T);
            await Task.Delay(100);
            return value;
        }
    }
}

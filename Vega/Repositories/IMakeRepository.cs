using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Models;

namespace Vega.Repositories
{
    public interface IMakeRepository
    {
        void Add(Make make);
        void Delete(Make make);
        Task<IEnumerable<Make>> GetAll();
        Task<Make> GetSingle(int id);
        bool Save();
        void Update(Make make);
    }
}
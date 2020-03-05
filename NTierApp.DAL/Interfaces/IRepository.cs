using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Interfaces
{
    public interface IRepository<T> where T: class //ограничение на обобщенный тип, т.е. обобщенным типом м.б. только класс
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}

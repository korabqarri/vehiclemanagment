using System.Collections.Generic;
using System.Data;

namespace FleetManagment.BO.Interface
{
    public interface IDataAccessLayer<T> where T : class
    {
        //void Add(T model);
        bool Add(T model);
        bool Modify(T model);
        bool Remove(int id);
        bool Remove(T model);

        T Get(int id);
        T Get(T model);
        IEnumerable<T> GetAll();

        T ToObject(IDataReader reader);

        //int Add(T model);


    }
}
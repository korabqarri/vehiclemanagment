using System.Collections.Generic;
using System.Windows.Forms;

namespace FleetManagment.Interface
{
    public interface IBasicCrudForm<T> where T:class
    {
        void ResetForm();

        void Delete();

        void Update();

        void Insert();

        T Get();

        List<T> GetAll();

    }
}
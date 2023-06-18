using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class ModelRepository : IModelRepository
    {
        public void AddData(Model data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Model data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Model> GetAll()
        {
            throw new NotImplementedException();
        }

        public Model GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Model data)
        {
            throw new NotImplementedException();
        }
    }
}

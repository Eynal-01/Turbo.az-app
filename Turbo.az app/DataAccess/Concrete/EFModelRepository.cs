using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFModelRepository : IModelRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(Model data)
        {
            _context.Models.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Model data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Model> GetAll()
        {
            var result = from m in _context.Models
                         select m;
            return new ObservableCollection<Model>(result);
        }

        public IQueryable<Model> GetAllId(int id)
        {
            return _context.Models.Where(m => m.BrandId == id);
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

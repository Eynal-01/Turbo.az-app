using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFCityRepository : ICityRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(City data)
        {
            _context.Cities.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAll()
        {
            var result = from c in _context.Cities
                         select c;
            return new ObservableCollection<City>(result);
        }

        public City GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}

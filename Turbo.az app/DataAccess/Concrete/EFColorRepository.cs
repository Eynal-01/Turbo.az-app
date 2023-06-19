using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFColorRepository : IColorRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(Entities.Mapping.Color data)
        {
            _context.Colors.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Entities.Mapping.Color data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Entities.Mapping.Color> GetAll()
        {
            var result = from c in _context.Colors
                         select c;
            return new ObservableCollection<Entities.Mapping.Color>(result);
        }

        public Entities.Mapping.Color GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Entities.Mapping.Color data)
        {
            throw new NotImplementedException();
        }
    }
}

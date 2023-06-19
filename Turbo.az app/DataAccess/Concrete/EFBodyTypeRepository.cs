using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFBodyTypeRepository : IBodyTypeRepository
    {
        TurboAzContext _context= new TurboAzContext();  
        public void AddData(BodyType data)
        {
            _context.BodyTypes.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(BodyType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<BodyType> GetAll()
        {
            var result = from bt in _context.BodyTypes  
                         select bt;
            return new ObservableCollection<BodyType>(result);
        }

        public BodyType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(BodyType data)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBodyTypeRepository bodyTypeRepository => throw new NotImplementedException();

        public IBrandRepository brandRepository => throw new NotImplementedException();

        public ICarRepository carRepository => throw new NotImplementedException();

        public ICityRepository cityRepository => throw new NotImplementedException();

        public IColorRepository colorRepository => throw new NotImplementedException();

        public IModelRepository modelRepository => throw new NotImplementedException();

        public IStatusRepository statusRepository => throw new NotImplementedException();
    }
}

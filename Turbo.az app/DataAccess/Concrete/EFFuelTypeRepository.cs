﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.Entities;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class EFFuelTypeRepository : IFuelTypeRepository
    {
        TurboAzContext _context = new TurboAzContext();
        public void AddData(FuelType data)
        {
            _context.FuelTypes.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(FuelType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<FuelType> GetAll()
        {
            var result = from ft in _context.FuelTypes
                         select ft;
            return new ObservableCollection<FuelType>(result);
        }

        public FuelType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(FuelType data)
        {
            throw new NotImplementedException();
        }
    }
}
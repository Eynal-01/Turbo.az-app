using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.DataAccess.Concrete;
using Turbo.az_app.Entities;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;
        public App()
        {
            DB = new UnitOfWork();

            DB.brandRepository.AddData(new Brand { BrandName = "Pagani" });
            DB.brandRepository.AddData(new Brand { BrandName = "Rolls Royce" });
            DB.brandRepository.AddData(new Brand { BrandName = "Lamborghini" });
            DB.brandRepository.AddData(new Brand { BrandName = "Bugatti" });

            DB.modelRepository.AddData(new Model { ModelName = "Huayra", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Utopia", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Zonda R", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Imola", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Phantom", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "Ghost", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "Cullinan", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "Huracan", BrandId = 3 });
            //DB.modelRepository.AddData(new Model { ModelName = "Huracan EVO", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Aventador", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Urus", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Chiron", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Veyron", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Divo", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Centodieci", BrandId = 4 });

            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Coupe" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Sedan" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "SUV" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Rodster" });

            DB.cityRepository.AddData(new City { CityName = "Baku" });
            DB.cityRepository.AddData(new City { CityName = "Sumgait" });
            DB.cityRepository.AddData(new City { CityName = "Shaki" });
            DB.cityRepository.AddData(new City { CityName = "Ganja" });
            DB.cityRepository.AddData(new City { CityName = "Nakhchivan" });

            DB.colorRepository.AddData(new Color { ColorName = "Orange" });
            DB.colorRepository.AddData(new Color { ColorName = "Green" });
            DB.colorRepository.AddData(new Color { ColorName = "Red" });
            DB.colorRepository.AddData(new Color { ColorName = "Yellow" });

            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Gasoline" });
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Diesel" });
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Electric" });
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Gas" });

            DB.carRepository.AddData(new Car
            {
                ColorId = 1,
                ModelId = 8,
                IsNew = false,
                BodyTypeId = 4,
                CityId = 1,
                Kilometer = 1200,
                Price = 235000,
                ProdYear = new DateTime(2015, 12, 12),
                ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F05%2F24%2F18%2F14%2F49%2Fbc615306-a67a-4954-889f-57268bb11f9e%2F14251_A8y547ZUuk1QKcWpLNzVHA.jpg",
                FuelTypeId = 1, 
                Engine = "5.2 L"
            }) ;

            DB.carRepository.AddData(new Car
            {
                ColorId = 2,
                ModelId = 1,
                IsNew = true,
                BodyTypeId = 4,
                CityId = 2,
                Kilometer = 0,
                Price = 7400000,
                ProdYear = new DateTime(2023, 2, 12),
                ImagePath= "https://www.gtopcars.com/wp-content/uploads/2021/10/2023-Pagani-Huayra-BC.jpg",
                FuelTypeId = 1,
                Engine = "6.0 L V-12"
            });

        }
    }
}

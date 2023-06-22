using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
        public static WrapPanel CarsWrapPanel { get; set; } = new WrapPanel();
        public static IUnitOfWork DB;
        public App()
        {
            DB = new UnitOfWork();
            if (DB.brandRepository.GetAll().Count == 0)
            {
                DB.brandRepository.AddData(new Brand { BrandName = "Pagani" });
                DB.brandRepository.AddData(new Brand { BrandName = "Rolls Royce" });
                DB.brandRepository.AddData(new Brand { BrandName = "Lamborghini" });
                DB.brandRepository.AddData(new Brand { BrandName = "Bugatti" });
                DB.brandRepository.AddData(new Brand { BrandName = "Tesla" });
            }

            if (DB.modelRepository.GetAll().Count == 0)
            {
                DB.modelRepository.AddData(new Model { ModelName = "Huayra", BrandId = 1 });
                DB.modelRepository.AddData(new Model { ModelName = "Phantom", BrandId = 2 });
                DB.modelRepository.AddData(new Model { ModelName = "Ghost", BrandId = 2 });
                DB.modelRepository.AddData(new Model { ModelName = "Cullinan", BrandId = 2 });
                DB.modelRepository.AddData(new Model { ModelName = "Huracan", BrandId = 3 });
                DB.modelRepository.AddData(new Model { ModelName = "Aventador", BrandId = 3 });
                DB.modelRepository.AddData(new Model { ModelName = "Urus", BrandId = 3 });
                DB.modelRepository.AddData(new Model { ModelName = "Chiron", BrandId = 4 });
                DB.modelRepository.AddData(new Model { ModelName = "Divo", BrandId = 4 });
                DB.modelRepository.AddData(new Model { ModelName = "Model X", BrandId = 5 });
            }

            if (DB.bodyTypeRepository.GetAll().Count == 0)
            {
                DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Coupe" });
                DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Sedan" });
                DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "SUV" });
                DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Rodster" });
            }

            if (DB.cityRepository.GetAll().Count == 0)
            {
                DB.cityRepository.AddData(new City { CityName = "Milano" });
                DB.cityRepository.AddData(new City { CityName = "Dubai" });
                DB.cityRepository.AddData(new City { CityName = "Singapur" });
                DB.cityRepository.AddData(new City { CityName = "London" });
                DB.cityRepository.AddData(new City { CityName = "Paris" });
            }


            if (DB.colorRepository.GetAll().Count == 0)
            {
                DB.colorRepository.AddData(new Color { ColorName = "Orange" });
                DB.colorRepository.AddData(new Color { ColorName = "Green" });
                DB.colorRepository.AddData(new Color { ColorName = "Black" });
                DB.colorRepository.AddData(new Color { ColorName = "Red" });
            }

            if (DB.fuelTypeRepository.GetAll().Count == 0)
            {
                DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Gasoline" });
                DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Diesel" });
                DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Electric" });
                DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Gas" });
            }

            if (DB.carRepository.GetAll().Count == 0)
            {
                DB.carRepository.AddData(new Car
                {
                    ColorId = 1,
                    ModelId = 5,
                    IsNew = false,
                    BodyTypeId = 4,
                    CityId = 1,
                    Kilometer = 1200,
                    Price = 235000,
                    ProdYear = new DateTime(2015, 12, 12),
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F05%2F24%2F18%2F14%2F49%2Fbc615306-a67a-4954-889f-57268bb11f9e%2F14251_A8y547ZUuk1QKcWpLNzVHA.jpg",
                    FuelTypeId = 2,
                    Engine = "5.2 L"
                });

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
                    ImagePath = "https://www.gtopcars.com/wp-content/uploads/2021/10/2023-Pagani-Huayra-BC.jpg",
                    FuelTypeId = 3,
                    Engine = "6.0 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 4,
                    ModelId = 2,
                    IsNew = false,
                    BodyTypeId = 2,
                    CityId = 3,
                    Kilometer = 10000,
                    Price = 890000,
                    ProdYear = new DateTime(2021, 3, 25),
                    ImagePath = "https://i.ytimg.com/vi/3PGFDiVt1ks/maxresdefault.jpg",
                    FuelTypeId = 2,
                    Engine = "6.0 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 3,
                    ModelId = 3,
                    IsNew = false,
                    BodyTypeId = 2,
                    CityId = 4,
                    Kilometer = 20000,
                    Price = 560000,
                    ProdYear = new DateTime(2020, 4, 20),
                    ImagePath = "https://www.mansory.com/sites/default/files/styles/1170_x_full_box_image/public/2022-11/MANSORY%20GHOST%2001.jpg?itok=NUYR1o_r",
                    FuelTypeId = 1,
                    Engine = "6.0 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 1,
                    ModelId = 4,
                    IsNew = true,
                    BodyTypeId = 3,
                    CityId = 1,
                    Kilometer = 0,
                    Price = 600000,
                    ProdYear = new DateTime(2023, 4, 20),
                    ImagePath = "https://www.carscoops.com/wp-content/uploads/2019/05/17c203de-rolls-royce-cullinan--1024x555.jpg",
                    FuelTypeId = 1,
                    Engine = "6.0 L V-12"
                });


                DB.carRepository.AddData(new Car
                {
                    ColorId = 2,
                    ModelId = 6,
                    IsNew = false,
                    BodyTypeId = 4,
                    CityId = 2,
                    Kilometer = 10200,
                    Price = 210000,
                    ProdYear = new DateTime(2014, 5, 10),
                    ImagePath = "https://www.lambocars.com/wp-content/uploads/2020/11/aventador_roadster_vorsteiner_hulk_1-1155x770.jpg",
                    FuelTypeId = 2,
                    Engine = "6.3 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 3,
                    ModelId = 5,
                    IsNew = false,
                    BodyTypeId = 4,
                    CityId = 2,
                    Kilometer = 10200,
                    Price = 210000,
                    ProdYear = new DateTime(2014, 5, 10),
                    ImagePath = "https://www.lambocars.com/wp-content/uploads/2020/11/aventador_roadster_vorsteiner_hulk_1-1155x770.jpg",
                    FuelTypeId = 4,
                    Engine = "6.3 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 4,
                    ModelId = 7,
                    IsNew = false,
                    BodyTypeId = 3,
                    CityId = 2,
                    Kilometer = 13500,
                    Price = 260500,
                    ProdYear = new DateTime(2019, 4, 3),
                    ImagePath = "https://f7432d8eadcf865aa9d9-9c672a3a4ecaaacdf2fee3b3e6fd2716.ssl.cf3.rackcdn.com/C2299/U8646/IMG_41442-large.jpg",
                    FuelTypeId = 3,
                    Engine = "6.5 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 1,
                    ModelId = 8,
                    IsNew = true,
                    BodyTypeId = 4,
                    CityId = 2,
                    Kilometer = 0,
                    Price = 5000000,
                    ProdYear = new DateTime(2023, 6, 15),
                    ImagePath = "https://www.arabianbusiness.com/cloud/2023/01/05/Andrew-Tate-Car-Collection.jpg",
                    FuelTypeId = 1,
                    Engine = "6.0 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 2,
                    ModelId = 9,
                    IsNew = false,
                    BodyTypeId = 4,
                    CityId = 3,
                    Kilometer = 1200,
                    Price = 10000000,
                    ProdYear = new DateTime(2016, 8, 23),
                    ImagePath = "https://scontent.fgyd9-1.fna.fbcdn.net/v/t1.6435-9/118186787_2968974199898111_1160004437372208799_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=9267fe&_nc_ohc=vk6gE0mBL2UAX_RhUzh&_nc_ht=scontent.fgyd9-1.fna&oh=00_AfCaZtahgdY-moWuY2WjNSBcwEITGeSoRPxx3RdRMM0Jvg&oe=64B7DE49",
                    FuelTypeId = 1,
                    Engine = "6.0 L V-12"
                });

                DB.carRepository.AddData(new Car
                {
                    ColorId = 3,
                    ModelId = 10,
                    IsNew = true,
                    BodyTypeId = 2,
                    CityId = 4,
                    Kilometer = 0,
                    Price = 3200000,
                    ProdYear = new DateTime(2023, 4, 12),
                    ImagePath = "https://www.carscoops.com/wp-content/uploads/2019/01/ce9e8a90-tsportline-tesla-model-x-orange-interior-47-1024x555.jpg",
                    FuelTypeId = 1,
                    Engine = "6.0 L V-12"
                });
            }
        }
    }
}

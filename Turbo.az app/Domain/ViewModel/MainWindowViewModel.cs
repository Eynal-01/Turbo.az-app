using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Turbo.az_app.Command;
using Turbo.az_app.Domain.Views;
using Turbo.az_app.Entities;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.Domain.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {

        public RelayCommand BrandSelectionChangedCommand { get; set; }
        public RelayCommand ModelSelectionChangedCommand { get; set; }
        public RelayCommand CitySelectionChangedCommand { get; set; }
        public RelayCommand BanTypeSelectionChangedCommand { get; set; }
        public RelayCommand ShowCommand { get; set; }

        private Brand selectedBrand;

        public Brand SelectedBrand
        {
            get { return selectedBrand; }
            set { selectedBrand = value; OnPropertyChanged(); }
        }

        private Model selectedModel;

        public Model SelectedModel
        {
            get { return selectedModel; }
            set { selectedModel = value; OnPropertyChanged(); }
        }

        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set { selectedCity = value; OnPropertyChanged(); }
        }

        private BodyType selectedBanType;

        public BodyType SelectedBanType
        {
            get { return selectedBanType; }
            set { selectedBanType = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Brand> brands;

        public ObservableCollection<Brand> Brands
        {
            get { return brands; }
            set { brands = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Model> models;

        public ObservableCollection<Model> Models
        {
            get { return models; }
            set { models = value; OnPropertyChanged(); }
        }

        private ObservableCollection<City> cities;

        public ObservableCollection<City> Cities
        {
            get { return cities; }
            set { cities = value; OnPropertyChanged(); }
        }

        private ObservableCollection<BodyType> banTypes;

        public ObservableCollection<BodyType> BanTypes
        {
            get { return banTypes; }
            set { banTypes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Entities.Mapping.Color> colors;

        public ObservableCollection<Entities.Mapping.Color> Colors
        {
            get { return colors; }
            set { colors = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FuelType> fuelTypes;

        public ObservableCollection<FuelType> FuelTypes
        {
            get { return fuelTypes; }
            set { fuelTypes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Car> cars;

        public ObservableCollection<Car> Cars
        {
            get { return cars; }
            set { cars = value; OnPropertyChanged(); }
        }

        private bool brandSelected = false;

        public bool BrandSelected
        {
            get { return brandSelected; }
            set { brandSelected = value; OnPropertyChanged(); }
        }

        private bool modelSelected = false;

        public bool ModelSelected
        {
            get { return modelSelected; }
            set { modelSelected = value; OnPropertyChanged(); }
        }

        private string minPrice;

        public string MinPrice
        {
            get { return minPrice; }
            set { minPrice = value; OnPropertyChanged(); }
        }

        private string maxPrice;

        public string MaxPrice
        {
            get { return maxPrice; }
            set { maxPrice = value; OnPropertyChanged(); }
        }
        private string minkm;

        public string Minkm
        {
            get { return minkm; }
            set { minkm = value; OnPropertyChanged(); }
        }

        private string maxkm;

        public string Maxkm
        {
            get { return maxkm; }
            set { maxkm = value; OnPropertyChanged(); }
        }

        public bool isAllCar { get; set; } = true;
        public bool isNewCar { get; set; } = false;

        public void CallCarUC(List<Car> cars)
        {
            App.CarsWrapPanel.Children.Clear();
            CarUC carUC;
            CarUCViewModel carUCViewModel;
            for (int i = 0; i < cars.Count; i++)
            {
                carUC = new CarUC();
                carUCViewModel = new CarUCViewModel();
                carUCViewModel.SelectedCar = cars[i];
                carUCViewModel.CarImagePath = cars[i].ImagePath;
                carUCViewModel.CarPrice = $"{cars[i].Price} AZN";
                carUCViewModel.CarName = $"{cars[i].Model.Brand.BrandName} {cars[i].Model.ModelName}";
                carUCViewModel.CarKmYearEngine = $"{cars[i].ProdYear.Year}, {cars[i].Engine}, {cars[i].Kilometer} km";
                carUC.DataContext = carUCViewModel;
                App.CarsWrapPanel.Children.Add(carUC);
            }
        }

        public MainWindowViewModel()
        {
            Brands = new ObservableCollection<Brand>(App.DB.brandRepository.GetAll());
            BanTypes = new ObservableCollection<BodyType>(App.DB.bodyTypeRepository.GetAll());
            Colors = new ObservableCollection<Entities.Mapping.Color>(App.DB.colorRepository.GetAll());
            FuelTypes = new ObservableCollection<FuelType>(App.DB.fuelTypeRepository.GetAll());
            Cars = new ObservableCollection<Car>(App.DB.carRepository.GetAll());
            CallCarUC(cars.ToList());

            BrandSelectionChangedCommand = new RelayCommand((obj) =>
            {
                var id = SelectedBrand.Id;
                Models = new ObservableCollection<Model>(App.DB.modelRepository.GetAllId(id));
                BrandSelected = true;
                ModelSelected = false;
            });

            ModelSelectionChangedCommand = new RelayCommand((obj) =>
            {
                ModelSelected = true;
            });

            ShowCommand = new RelayCommand((obj) =>
            {
                if (!BrandSelected && isNewCar)
                {
                    var allCars = Cars.Where(c => c.IsNew).ToList();
                    CallCarUC(allCars);
                };
                if (!BrandSelected && !isNewCar)
                {
                    var allCars = Cars.Where(c => c.IsNew == false).ToList();
                    CallCarUC(allCars);
                }
                if (minPrice != null && minPrice != String.Empty)
                {
                    int price = Convert.ToInt32(minPrice);
                    var allcars = Cars.Where((c) => { return c.Price >= price; }).ToList();
                }
                if (maxPrice != null && maxPrice != String.Empty)
                {
                    int price = Convert.ToInt32(maxPrice);
                    var allcars = Cars.Where((c) => { return c.Price <= price; }).ToList();
                }
                if (Minkm != null && Minkm != String.Empty)
                {
                    int km = Convert.ToInt32(minkm);
                    var allcars = Cars.Where((c) => { return c.Kilometer >= km; }).ToList();
                }
                if (Maxkm != null && Maxkm != String.Empty)
                {
                    int km = Convert.ToInt32(Maxkm);
                    var allcars = Cars.Where((c) => { return c.Kilometer <= km; }).ToList();
                }
                if (!ModelSelected && BrandSelected || isAllCar)
                {

                    var allCars = Cars.Where(c => c.Model.BrandId == SelectedBrand.Id).ToList();
                    CallCarUC(allCars);
                }
                if (isNewCar && BrandSelected)
                {
                    var allCars = Cars.Where(c => c.Model.BrandId == SelectedBrand.Id && c.IsNew == true).ToList();
                    CallCarUC(allCars);
                }
                else if (!isNewCar && !isAllCar && BrandSelected)
                {
                    var allCars = Cars.Where(c => c.Model.BrandId == SelectedBrand.Id && c.IsNew == false).ToList();
                    CallCarUC(allCars);
                }
                if (ModelSelected)
                {
                    var allCars = Cars.Where(c => c.ModelId == SelectedModel.Id).ToList();
                    CallCarUC(allCars);
                }
            });
        }
    }
}
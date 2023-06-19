using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Command;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.Domain.ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {

        public RelayCommand VendorSelectionChangedCommand { get; set; }
        public RelayCommand ModelSelectionChangedCommand { get; set; } 
        public RelayCommand CitySelectionChangedCommand { get; set; }   
        public RelayCommand BanTypeSelectionChangedCommand { get; set; }    

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
            set { models = value; }
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


        private bool brandSelected;

        public bool BrandSelected
        {
            get { return brandSelected; }
            set { brandSelected = value; OnPropertyChanged(); }
        }



        public MainWindowViewModel()
        {
            
        }
    }
}

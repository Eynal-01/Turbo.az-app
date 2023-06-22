using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Command;
using Turbo.az_app.Domain.Views;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.Domain.ViewModel
{
    public class CarUCViewModel:BaseViewModel
    {
        public RelayCommand SelectedCarCommand { get; set; }

		private string carPrice;

		public string CarPrice
		{
			get { return carPrice; }
			set { carPrice = value; OnPropertyChanged(); }
		}

		private string carImagePath;

		public string CarImagePath
		{
			get { return carImagePath; }
			set { carImagePath = value; OnPropertyChanged(); }
		}

		private string carName;

		public string CarName
		{
			get { return carName; }
			set { carName = value; OnPropertyChanged(); }
		}

		private string carKmYearEngine;

		public string CarKmYearEngine
		{
			get { return carKmYearEngine; }
			set { carKmYearEngine = value; OnPropertyChanged(); }
		}

		private Car selectedCar;

		public Car SelectedCar
		{
			get { return selectedCar; }
			set { selectedCar = value; }
		}

		public CarUCViewModel()
        {
			SelectedCarCommand = new RelayCommand((obj) =>
			{
				App.CarsWrapPanel.Children.Clear();
				CarSideUC carSideUC = new CarSideUC();
				CarSideUCViewModel carSideViewModel = new CarSideUCViewModel();
				carSideViewModel.CarBrand = SelectedCar.Model.Brand.BrandName;
				carSideViewModel.CarPrice = SelectedCar.Price;
				carSideViewModel.CarColor = SelectedCar.Color.ColorName;
				carSideViewModel.CarEngine = SelectedCar.Engine;
				carSideViewModel.CarModel = SelectedCar.Model.ModelName;
				carSideViewModel.CarYear = SelectedCar.ProdYear.Year.ToString();
				carSideViewModel.CityOfCar = SelectedCar.City.CityName;
			});
		}
    }
}

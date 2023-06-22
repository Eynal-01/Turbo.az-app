using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Command;

namespace Turbo.az_app.Domain.ViewModel
{
    public class CarSideUCViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

		private string carBrand;

		public string CarBrand
		{
			get { return carBrand; }
			set { carBrand = value; OnPropertyChanged(); }
		}

		private string carEngine;

		public string CarEngine
		{
			get { return carEngine; }
			set { carEngine = value; OnPropertyChanged(); }
		}

		private string carColor;

		public string CarColor
		{
			get { return carColor; }
			set { carColor = value; OnPropertyChanged(); }
		}

		private string cityOfCar;

		public string CityOfCar
		{
			get { return cityOfCar; }
			set { cityOfCar = value; OnPropertyChanged(); }
		}

		private string imagePath;

		public string ImagePath
		{
			get { return imagePath; }
			set { imagePath = value; OnPropertyChanged(); }
		}

		private string carModel;

		public string CarModel
		{
			get { return carModel; }
			set { carModel = value; OnPropertyChanged(); }
		}

		private decimal carPrice;

		public decimal CarPrice
		{
			get { return carPrice; }
			set { carPrice = value; OnPropertyChanged(); }
		}

		private string carYear;
	
		public string CarYear
		{
			get { return carYear; }
			set { carYear = value; OnPropertyChanged(); }
		}

        public CarSideUCViewModel()
        {
			BackCommand = new RelayCommand((obj) =>
			{
				var vm = new MainWindowViewModel();
			});
        }
    }
}

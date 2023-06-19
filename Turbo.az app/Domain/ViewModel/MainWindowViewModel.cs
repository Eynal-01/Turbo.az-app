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

        public RelayCommand VendorSelectionChanged { get; set; }


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

        private ObservableCollection<Brand> brands;

        public ObservableCollection<Brand> Brands
        {
            get { return brands; }
            set { brands = value; OnPropertyChanged(); }
        }


        public MainWindowViewModel()
        {
            
        }
    }
}

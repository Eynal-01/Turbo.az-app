﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Turbo.az_app.Domain.ViewModel;

namespace Turbo.az_app.Domain.Views
{
    /// <summary>
    /// Interaction logic for CarInfoUC.xaml
    /// </summary>
    public partial class CarSideUC : UserControl
    {
        public CarSideUC()
        {
            InitializeComponent();
            var vm = new CarSideUCViewModel();
            this.DataContext = vm;
        }
    }
}

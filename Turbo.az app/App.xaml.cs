using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.DataAccess.Concrete;

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










        }
    }
}

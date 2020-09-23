using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Visuals;

namespace ShapesManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var window = new MainWindow();

            var vm = new ShapeVM();
            vm.ShapeName = "Circle";
            vm.ShapeColor = "Red";
            vm.ShapeSize = .5;
            vm.ShapeX = 10;
            vm.ShapeY = 7;

            window.DataContext = vm;
            window.Show();
        }
    }
}

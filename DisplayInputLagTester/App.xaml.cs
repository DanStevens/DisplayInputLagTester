using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DisplayInputLagTester.ViewModels;
using DisplayInputLagTester.Views;

namespace DisplayInputLagTester
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public const string Name = "Display Input Lag Tester";

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var clockViewModel = new ClockViewModel();

            var mainWindow = CreateWindow(clockViewModel, Name);
            mainWindow.Show();

            var secondaryWindow = CreateWindow(clockViewModel, Name);
            secondaryWindow.Show();
        }

        private Window CreateWindow(ClockViewModel viewModel, string title)
        {
            var view = new ClockView() {DataContext = viewModel};
            var window = new Window()
            {
                Content = view,
                Title = title,
                Width = 400,
                Height = 250
            };
            return window;
        }
    }
}

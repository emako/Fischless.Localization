﻿using System.Windows;
using Antelcat.I18N.WPF.Demo.Windows;

namespace Antelcat.I18N.WPF.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new MainWindow().Show();
        }
       
    }
}
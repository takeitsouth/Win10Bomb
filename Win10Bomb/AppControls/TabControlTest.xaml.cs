using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Bombardier.AppControls
{
    public sealed partial class TabControlTest : UserControl
    {
        private TabPages.MelCdl melCdl = new TabPages.MelCdl();
        private TabPages.Notam notam = new TabPages.Notam();
        private TabPages.Results results = new TabPages.Results();
        private TabPages.ResultsFms resultsFms = new TabPages.ResultsFms();

        public TabControlTest()
        {
            this.InitializeComponent();
        }

        private void MelCdlClick(object sender, RoutedEventArgs e)
        {
            TabContent.Content = melCdl;
        }

        private void NotamClick(object sender, RoutedEventArgs e)
        {
            TabContent.Content = notam;
        }

        private void ResultsClick(object sender, RoutedEventArgs e)
        {
            TabContent.Content = results;
        }
    }
}

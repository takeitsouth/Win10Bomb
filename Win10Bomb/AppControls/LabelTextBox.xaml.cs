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
    public sealed partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            this.InitializeComponent();
            DataContext = this;
            LblWidth = new GridLength(2, GridUnitType.Star);
            TbWidth = new GridLength(3, GridUnitType.Star);
        }

        public GridLength LblWidth
        {
            get { return (GridLength)GetValue(LblWidthProperty); }
            set { SetValue(LblWidthProperty, value); }
        }

        public GridLength TbWidth
        {
            get { return (GridLength)GetValue(TbWidthProperty); }
            set { SetValue(TbWidthProperty, value); }
        }


        public string Lbl
        {
            get { return (string)GetValue(LblProperty); }
            set { SetValue(LblProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyLblProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LblProperty =
            DependencyProperty.Register("Lbl", typeof(string), typeof(LabelTextBox), new PropertyMetadata(0));

        public static readonly DependencyProperty LblWidthProperty =
            DependencyProperty.Register("LblWidth", typeof(GridLength), typeof(LabelTextBox), new PropertyMetadata(0));

        public static readonly DependencyProperty TbWidthProperty =
            DependencyProperty.Register("TbWidth", typeof(GridLength), typeof(LabelTextBox), new PropertyMetadata(0));
    }
}

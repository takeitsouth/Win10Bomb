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
    public sealed partial class LabelComboBox : UserControl
    {
        public LabelComboBox()
        {
            this.InitializeComponent();
            DataContext = this;
            LblWidth = new GridLength(2, GridUnitType.Star);
            CbWidth = new GridLength(3, GridUnitType.Star);
        }

        public string Lbl
        {
            get { return (string)GetValue(LblProperty); }
            set { SetValue(LblProperty, value); }
        }

        public GridLength LblWidth
        {
            get { return (GridLength)GetValue(LblWidthProperty); }
            set { SetValue(LblWidthProperty, value); }
        }

        public GridLength CbWidth
        {
            get { return (GridLength)GetValue(CbWidthProperty); }
            set { SetValue(CbWidthProperty, value); }
        }

        public List<string> CbItems
        {
            get { return (List<string>)GetValue(CbItemsProperty); }
            set { SetValue(CbItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Lbl.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LblProperty =
            DependencyProperty.Register("Lbl", typeof(string), typeof(LabelComboBox), new PropertyMetadata(0));

        public static readonly DependencyProperty LblWidthProperty =
            DependencyProperty.Register("LblWidth", typeof(GridLength), typeof(LabelComboBox), new PropertyMetadata(0));

        public static readonly DependencyProperty CbWidthProperty =
            DependencyProperty.Register("CbWidth", typeof(GridLength), typeof(LabelComboBox), new PropertyMetadata(0));

        public static readonly DependencyProperty CbItemsProperty =
            DependencyProperty.Register("CbItems", typeof(List<string>), typeof(LabelComboBox), new PropertyMetadata(0));
    }
}

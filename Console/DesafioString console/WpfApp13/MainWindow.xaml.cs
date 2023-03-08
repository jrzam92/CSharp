using System;
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

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private int clickedCount=0;

        public MainWindow()
        {
            InitializeComponent();
            SetValue(TitleProperty, "CSMainWindow");
           // this.Height = 350;
           // this.Width = 525;
           // //Instantiate each object (element) in the Window
           // _ButtonText = new TextBlock();
           // _ButtonText.Text = "Click Me!";
           // _ButtonText.FontSize = 100.0;
           // _BtnClickOk = new Button();
           // _BtnClickOk.Content = _ButtonText;
           // _ContentGrid = new Grid();
           // _ContentGrid.Children.Add(_BtnClickOk);
           // this.Content = _ContentGrid;
           //_ButtonTextz
        }
        private void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            TextBlockLabel.Text = string.Format("Clicked {0} time(s)",
           ++clickedCount);
        }
    }
}

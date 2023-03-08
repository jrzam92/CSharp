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

namespace WpfApp01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid=new Grid();
            this.Content = grid;
            Button btn=new Button();
            btn.FontSize = 24;
            WrapPanel wp=new WrapPanel();

            TextBlock txtb1= new TextBlock();
            txtb1.Text = "Boton";
            txtb1.Foreground = Brushes.Blue;
            wp.Children.Add(txtb1);

            TextBlock txtb2 = new TextBlock();
            txtb2.Text = "Multi";
            txtb2.Foreground = Brushes.Red;
            wp.Children.Add(txtb2);

            TextBlock txtb3 = new TextBlock();
            txtb3.Text = "Color";
            txtb3.Foreground = Brushes.Green;
            wp.Children.Add(txtb3);

            btn.Content= wp;
            grid.Children.Add(btn); 

        }
    }
}

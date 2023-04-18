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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbxIngredientes_Checked(object sender, RoutedEventArgs e)
        {
            bool nuevoValor = (cbxTodos.IsChecked == true);
            cbxChile.IsChecked = nuevoValor;
            cbxHongos.IsChecked = nuevoValor;
            cbxMozzarela.IsChecked = nuevoValor;
        }
        private void cbxSimple_Checked(object sender, RoutedEventArgs e)
        {
            cbxTodos.IsChecked = null;
            if ((cbxChile.IsChecked == true) && (cbxHongos.IsChecked == true) && (cbxMozzarela.IsChecked == true))
            {
                cbxTodos.IsChecked = true;
            }
            if ((cbxChile.IsChecked == false) && (cbxHongos.IsChecked == false) && (cbxMozzarela.IsChecked == false))
            {
                cbxTodos.IsChecked = false;
            }
        }
    }
}

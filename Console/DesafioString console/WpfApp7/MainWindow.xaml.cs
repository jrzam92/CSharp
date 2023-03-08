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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Se puede usar para metricas de un juego o algo administrativo o algo de estadisticas
            List<Juego> juegos= new List<Juego>();
            juegos.Add(new Juego() { 
            Eq1="Barcelona",
            Eq2="Real Madrid",
            Puntaje1=0,
            Puntaje2=1,
            Progreso=20,
            });
            juegos.Add(new Juego()
            {
                Eq1 = "Barcelona",
                Eq2 = "Real Madrid",
                Puntaje1 = 1,
                Puntaje2 = 1,
                Progreso = 45,
            });
            juegos.Add(new Juego()
            {
                Eq1 = "Barcelona",
                Eq2 = "Real Madrid",
                Puntaje1 = 2,
                Puntaje2 = 1,
                Progreso = 65,
            });
            juegos.Add(new Juego()
            {
                Eq1 = "Barcelona",
                Eq2 = "Real Madrid",
                Puntaje1 = 3,
                Puntaje2 = 2,
                Progreso = 85,
            });
            //Invocacion de elementos visuales 
            lstJuego.ItemsSource= juegos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lstJuego.SelectedItem != null) {
                string message = string.Format("El juego seleccionado:\n {0} {1}\n {2} {3}",
                    (lstJuego.SelectedItem as Juego).Eq1,
                    (lstJuego.SelectedItem as Juego).Puntaje1,
                    (lstJuego.SelectedItem as Juego).Eq2,
                    (lstJuego.SelectedItem as Juego).Puntaje2
                    );

                MessageBox.Show(message);
            }
        }
    }

    public class Juego {

        public int Puntaje1 { get; set; }
        public int Puntaje2 { get; set; }

        public string Eq1 { get; set; }

        public string Eq2 { get; set; }

        public int Progreso { get; set; }


    }
}

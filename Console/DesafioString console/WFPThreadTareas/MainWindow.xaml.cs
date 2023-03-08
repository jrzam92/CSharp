using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WFPThreadTareas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty dependencyProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string), typeof(MainWindow),
            new FrameworkPropertyMetadata(CambioEnHtml) 
            );
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miBoton_Click(RoutedEventArgs e)
        {

        }

        private  void miBoton_Click(object sender, RoutedEventArgs e)
        {
            ///Creacion de tarea
            Task.Run(() =>
            {
                ///Validacion de hilo 
                Debug.WriteLine($"Hilo numero: {Thread.CurrentThread.ManagedThreadId}");
                ///Orden de navegacion para obtener un resultado 
                HttpClient httpClient = new HttpClient();
                //string html = httpClient.GetStringAsync("https://google.com").Result;
                string html = httpClient.GetStringAsync("https://autogestion.metrotel.com.ar/speedtest/archivo5MB.zip").Result;



                miBoton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Hilo numero: {Thread.CurrentThread.ManagedThreadId} posee boton");
                    //Cuando esta en un hilo este subproceso puede entrar en una excepcion 
                    miBoton.Content = "Listo";
                });
            });
        }
        private async void miBoton2_Click(object sender, RoutedEventArgs e)
        {
            string miHtml = string.Empty;
            Debug.WriteLine($"Hilo numero: {Thread.CurrentThread.ManagedThreadId} antes de la tarea ");
            ///Creacion de tarea en modo asincrono
            await Task.Run(async () =>
            {
                ///Validacion de hilo 
                Debug.WriteLine($"Hilo numero: {Thread.CurrentThread.ManagedThreadId} durante de la tarea ");
                ///Orden de navegacion para obtener un resultado 
                HttpClient httpClient = new HttpClient();
                //string html = httpClient.GetStringAsync("https://google.com").Result;
                //string html = httpClient.GetStringAsync("https://autogestion.metrotel.com.ar/speedtest/archivo5MB.zip").Result;
                string html = httpClient.GetStringAsync("https://escueladirecta.com").Result;

                miHtml = html;
            });
                Debug.WriteLine($"Hilo numero: {Thread.CurrentThread.ManagedThreadId} terminada de la tarea "); 
                 miBoton.Content = "Descargado";
            MiNavegador.SetValue(dependencyProperty,miHtml);
        }
        static void CambioEnHtml(DependencyObject objetoDependiente, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser NavegadorWeb = objetoDependiente as WebBrowser;
            if (NavegadorWeb != null)
                NavegadorWeb.NavigateToString(e.NewValue as string);
        }
    }
}

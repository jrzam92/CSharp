using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace GestionZoo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["GestionZoo.Properties.Settings.ConnectionString"].ConnectionString;
            
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
            ShowAnimal();
        }

        private void ShowZoos() {
            try
            {

            string query = " select * from Zoo";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            using(sqlDataAdapter)
            {
                DataTable zooTable=new DataTable();
                sqlDataAdapter.Fill(zooTable);
                ///Muestra la columna que se requiere mostrar 
                lstZoos.DisplayMemberPath = "Ubicación";
                ///Selecciona el valor que tiene la tabla
                lstZoos.SelectedValuePath = "Id";
                //Moestras los resultados 
                lstZoos.ItemsSource = zooTable.DefaultView;
            }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        private void ShowAnimal()
        {
            try
            {

                string query = " select * from Animal";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    ///Muestra la columna que se requiere mostrar 
                    lstAnimal.DisplayMemberPath = "Nombre";
                    ///Selecciona el valor que tiene la tabla
                    lstAnimal.SelectedValuePath = "Id";
                    //Moestras los resultados 
                    lstAnimal.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        private void ShowMatchZooAnimals()
        {
            try
            {
                ///"@ZooId" es el valor que se va a estar seleccionando de la (objeto)lista 
                //string query ="select * from Animal a Inner Join AnimalZoo az on a.Id=az.Id where az.ZooId=@ZooId";
                string query = "select * from Zoo z inner join AnimalZoo az on az.ZooID=z.Id inner Join Animal a on az.AnimalId=a.Id where z.Id=@ZooId";
                SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    
                    sqlCommand.Parameters.AddWithValue("@ZooId",lstZoos.SelectedValue);
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    ///Muestra la columna que se requiere mostrar 
                    lstAnimals.DisplayMemberPath = "Nombre";
                    ///Selecciona el valor que tiene la tabla
                    lstAnimals.SelectedValuePath = "Id";
                    //Moestras los resultados 
                    lstAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {

                //MessageBox.Show(e.ToString());
            }
        }

        private void ShowTBZooSelected() {
            try
            {
                 
                
                string query = "select Ubicación from Zoo where Id=@ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {


                    sqlCommand.Parameters.AddWithValue("@ZooId", lstZoos.SelectedValue);
                    DataTable zooDTable = new DataTable();
                    sqlDataAdapter.Fill(zooDTable);
                    txtNewZoo.Text= zooDTable.Rows[0]["Ubicación"].ToString();
                }
            }
            catch (Exception e)
            {

                //MessageBox.Show(e.ToString());
            }
        }
        private void ShowTBAnimalSelected()
        {
            try
            {


                string query = "select Nombre from Animal where Id=@AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {


                    sqlCommand.Parameters.AddWithValue("@AnimalId", lstAnimal.SelectedValue);
                    DataTable animalDTable = new DataTable();
                    sqlDataAdapter.Fill(animalDTable);
                    txtNewAnimal.Text = animalDTable.Rows[0]["Nombre"].ToString();
                }
            }
            catch (Exception e)
            {

                //MessageBox.Show(e.ToString());
            }
        }
        private void lstZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowMatchZooAnimals();
            ShowTBZooSelected();
        }

        private void EliminarZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where Id=@ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", lstZoos.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally {  
            sqlConnection.Close();
            ShowZoos();
            }
        }

        private void AgregarZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values(@Ubicación)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Ubicación", txtNewZoo.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                txtNewZoo.Text=string.Empty;
                ShowZoos();
            }
        }

        private void AddAnimalZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into AnimalZoo values(@ZooId,@AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", lstZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", lstAnimal.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowMatchZooAnimals();
            }
        }
        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Zoo set Ubicación = @Ubicación where Id=@ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", lstZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Ubicación", txtNewZoo.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                txtNewZoo.Text = string.Empty;
                ShowZoos();
            }
        }
        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal set Nombre = @Nombre where Id=@AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", lstAnimal.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Nombre", txtNewAnimal.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimal();
                txtNewAnimal.Text = string.Empty;
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values(@Nombre)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Nombre", txtNewAnimal.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                txtNewAnimal.Text = string.Empty;
                ShowAnimal();
            }
        }

        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where Id=@AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", lstAnimal.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimal();
            }
        }

        private void DeleteMatchAnimalZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from AnimalZoo where AnimalId = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", lstAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowMatchZooAnimals();
            }
        }

        private void lstAnimal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTBAnimalSelected();
        }

        private void lstAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowMatchZooAnimals();
        }
    }
}

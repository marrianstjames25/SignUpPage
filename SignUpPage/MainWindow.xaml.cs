using System;
using System.Collections.Generic;
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

namespace SignUpPage
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

        string sqlCon = @"Data Source=LAB108PC23\SQLEXPRESS; Initial Catalog=SignUp; Integrated Security=True;";

        //string sqlCon = "SERVER NAME/DATABASE NAME/Protected or not"


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //char[] arr = { '!', '@', '*', '_', '?', '.', '(', ')', '%', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '=', '$', '&', '^', '~' };
            //string ran = arr.ToString();


            //if (pswdBox.Password.Length<8 || !pswdBox.Password.Contains(ran))
            //{
            //    MessageBox.Show("Wrong attempt.Go back and try again","error",MessageBoxButton.YesNoCancel,MessageBoxImage.Error);

            //} else if(!txtEmail.Text.Contains('@'))
            //{

            //    MessageBox.Show("You have not entered a valid email address");
            //}



            //else
            //{
            //    MessageBox.Show($"Your username is :{txtUsername.Text}, and your password is:{pswdBox.Password}");
            //}


        }

        private void usernameClear(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void clearFirstName(object sender, RoutedEventArgs e)
        {
            txtFName.Text = "";
        }

        private void Insert_(object sender, RoutedEventArgs e)
        {
            //establish the connection

            SqlConnection conn = new SqlConnection(sqlCon);

            try
            {
                //open the conneciton to the db 
                conn.Open();

                //create the query 

                string query = $"Insert into Credentials_table(Username,FirstName,LastName,Email,Password) values ('{txtUsername.Text}','{txtFName.Text}','{txtLname.Text}','{txtEmail.Text}','{pswdBox.Password}')";
                //establish the conn between the query and the db

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success it works fine!");

            }
            catch (Exception ex)
            {

              MessageBox.Show(ex.Message);
            }
            




        }
    }
}

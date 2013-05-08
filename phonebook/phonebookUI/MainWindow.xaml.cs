using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace phonebookUI
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
        public ObservableCollection<phonebook> obj = new ObservableCollection<phonebook>();
        public ObservableCollection<phonebook> phonebookcollection
        {
            get
            {
                return obj;
            }
        }
        public class phonebook
        {
public  string pName;
public  string pmobileno;
public  string pid;
            string id { get;set;}
            string name {get;set;}
            string mobileno { get; set; }
        }


             
private void Window_Loaded(object sender, RoutedEventArgs e) 
{

//define the connection reference

MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; user id=root;password=technicise;database=my_schema;persist security info=false");

//open the connection

if (msqlConnection.State != System.Data.ConnectionState.Open)

msqlConnection.Open();

//define the command reference

MySql.Data.MySqlClient.MySqlCommand msqlcommand = new MySql.Data.MySqlClient.MySqlCommand();

//define the connection used by the command object

msqlcommand.Connection = msqlConnection;

//define the command text

msqlcommand.CommandText = "select * from phonebook";

MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlcommand.ExecuteReader();

obj.Clear();

while (msqlReader.Read())

{

// every object should be newly created

phonebook studentInfoObject = new phonebook();

studentInfoObject.pid = msqlReader.GetString("id");

studentInfoObject.pName = msqlReader.GetString("name");
    studentInfoObject.pmobileno= msqlReader.GetString("mobileno");

phonebookcollection.Add(studentInfoObject);

}

//close the connection

msqlConnection.Close();

}
        }

        
    }


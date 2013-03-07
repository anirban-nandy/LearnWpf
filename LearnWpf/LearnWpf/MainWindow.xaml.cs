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

namespace LearnWpf
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
        string str = "";
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (checkBox1.IsChecked == true)
                str = str + checkBox1.Content + "\n";
            if (checkBox2.IsChecked == true)
                str = str + checkBox2.Content + "\n";
            if (checkBox3.IsChecked == true)
                str = str + checkBox3.Content + "\n";
            if (checkBox4.IsChecked == true)
                str = str + checkBox4.Content + "\n";

            MessageBox.Show(str);
            str = "";
        }
        private void hyper_Clrick(object sender, RoutedEventArgs e)
        {
            LearnWpf.anotherwindow anotherwindowobj = new LearnWpf.anotherwindow();
            anotherwindowobj.Show();
        }
    }
}

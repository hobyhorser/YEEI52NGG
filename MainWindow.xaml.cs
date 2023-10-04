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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int a = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = Log.Text;
            string parol = Parol.Text;

            while (a > 3)
            {
                if (log == "qqwq" && parol == "1234567")
                {
                    www.Text = "Доступ разрешён";
                }
            } 
        }
    }
}

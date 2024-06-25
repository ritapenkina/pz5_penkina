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

namespace pz1_penkina
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var text = tbText.Text;
            var search = tbSearch.Text;
            var result = "";

            var arr = text.Split();

            foreach (var line in arr)
            {
                if (line.Contains(search))
                {
                    result += line + Environment.NewLine;
                }
            }

            tbResult.Text = result;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbText.Text = string.Empty;
            tbSearch.Text = string.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

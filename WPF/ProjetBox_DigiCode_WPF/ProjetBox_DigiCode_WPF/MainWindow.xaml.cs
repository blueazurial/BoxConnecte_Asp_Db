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

namespace ProjetBox_DigiCode_WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // fonction permettant de concatener le nombre clicker au code
        private void add(object sender,RoutedEventArgs e)
        {
            Button but = (Button)sender;
            TXT.Text += but.Content.ToString();
        }
        // remet le code à zero
        private void Reset(object sender,RoutedEventArgs e)
        {
            TXT.Text = "";
        }
    }

}

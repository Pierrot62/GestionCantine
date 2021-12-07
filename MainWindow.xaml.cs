using GestionCantine.Formulaires;
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

namespace GestionCantine
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

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            string NameWindow = (string)((Button)sender).Content;
            switch (NameWindow)
            {
                case "Reservations":
                    Reservations window = new();
                    window.ShowDialog();
                    break;
                case "Eleves":
                    Eleves EleveWindow = new();
                    EleveWindow.ShowDialog();
                    break;
                case "Paiements":
                    Paiements PaiementsWindow = new();
                    PaiementsWindow.ShowDialog();
                    break;
                case "Menus":
                    Menus MenuWindow = new();
                    MenuWindow.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}

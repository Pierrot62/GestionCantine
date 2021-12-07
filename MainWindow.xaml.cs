using GestionCantine.Listes;
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
            double hauteur = this.Height;
            double largueur = this.Width; 
            switch (NameWindow)
            {
                case "Reservations":
                    Reservations ReservationWindow = new();
                    ReservationWindow.Width = largueur;
                    ReservationWindow.Height = hauteur;
                    ReservationWindow.ShowDialog();
                    break;
                case "Eleves":
                    Eleves EleveWindow = new();
                    EleveWindow.Width = largueur;
                    EleveWindow.Height = hauteur;
                    EleveWindow.ShowDialog();
                    break;
                case "Paiements":
                    Paiements PaiementWindow = new();
                    PaiementWindow.Width = largueur;
                    PaiementWindow.Height = hauteur;
                    PaiementWindow.ShowDialog();
                    break;
                case "Menus":
                    Menus MenuWindow = new();
                    MenuWindow.Width = largueur;
                    MenuWindow.Height = hauteur;
                    MenuWindow.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}

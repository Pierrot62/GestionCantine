using GestionCantine.Data;
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
        public GCantineContext _context { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            string NameWindow = (string)((Button)sender).Content;
            double left = this.Left;
            double top = this.Top; 
            switch (NameWindow)
            {
                case "Reservations":
                    Reservations ReservationWindow = new(this, _context);
                    ReservationWindow.Left = left;
                    ReservationWindow.Top = top;
                    this.Visibility = Visibility.Hidden;
                    ReservationWindow.ShowDialog();
                    break;
                case "Eleves":
                    Eleves EleveWindow = new(this, _context);
                    EleveWindow.Left = left;
                    EleveWindow.Top = top;
                    this.Visibility = Visibility.Hidden;
                    EleveWindow.ShowDialog();
                    break;
                case "Paiements":
                    Paiements PaiementWindow = new(this, _context);
                    PaiementWindow.Left = left;
                    PaiementWindow.Top = top;
                    PaiementWindow.ShowDialog();
                    break;
                case "Menus":
                    Menus MenuWindow = new();
                    MenuWindow.Left = left;
                    MenuWindow.Top = top;
                    MenuWindow.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}

using GestionCantine.Controllers;
using GestionCantine.Data;
using GestionCantine.Formulaires;
using GestionCantine.Data.Dtos;
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
using System.Windows.Shapes;
using GestionCantine.Data.Models;

namespace GestionCantine.Listes
{
    /// <summary>
    /// Logique d'interaction pour Reservations.xaml
    /// </summary>
    public partial class Reservations : Window
    {
        private MainWindow _FenetreMere { get; set; }
        private ReservationController _ReservationController { get; set; }
        private GCantineContext _Ctx { get; set; }

        public Reservations(MainWindow _FenetreMere, GCantineContext _ctx)
        {
            InitializeComponent();
            this._FenetreMere = _FenetreMere;
            this._ReservationController = new ReservationController(_ctx);
            this._Ctx = _ctx;
            Init();
        }

        private void Init()
        {
            dg.ItemsSource = _ReservationController.GetAllReservation();
        }



        private void Back(object sender, RoutedEventArgs e)
        {
            if (this.Left != this._FenetreMere.Left || this.Top != this._FenetreMere.Top)
            {
                this._FenetreMere.Left = this.Left;
                this._FenetreMere.Top = this.Top;
            }
            this._FenetreMere.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Button_Action(object sender, RoutedEventArgs e)
        {
            ReservationsForm reservationForm = new((string)((Button)sender).Content, this, (Reservation)dg.SelectedItem, _Ctx);
            reservationForm.Left = this.Left;
            reservationForm.Top = this.Top;
            this.Visibility = Visibility.Hidden;
            reservationForm.ShowDialog();
        }
    }
}

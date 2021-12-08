using GestionCantine.Controllers;
using GestionCantine.Data;
using GestionCantine.Data.Dtos;
using GestionCantine.Data.Models;
using GestionCantine.Help;
using GestionCantine.Listes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GestionCantine.Formulaires
{
    /// <summary>
    /// Logique d'interaction pour ReservationsForm.xaml
    /// </summary>
    public partial class ReservationsForm : Window
    {
        private string _Action { get; set; }
        private Reservations _FenetreMere { get; set; } // Fenetre Mere qui a pour nom Reservations
        private Reservation _SelectedObj { get; set; } // Le model Reservation
        private GCantineContext _Ctx { get; set; }

        private ReservationController _ReservationController { get; set; }
        private EleveController _EleveController { get; set; }
        private MenuController _MenuController { get; set; }

        public ReservationsForm(string action, Reservations FenetreMere,Reservation selectedObj,GCantineContext context)
        {
            InitializeComponent();
            this._Action = action;
            this._FenetreMere = FenetreMere;
            this._SelectedObj = selectedObj;
            this._Ctx = context;
            Init();
        }

        private void Init()
        {
            this.titreForm.Content = _Action + " une réservation";
            this.action.Content = _Action;
            this.dateReservationPicker.SelectedDate = DateTime.Now;
            _ReservationController = new ReservationController(_Ctx);
            _EleveController = new EleveController(_Ctx);
            _MenuController = new MenuController(_Ctx);
            this.dgEleve.ItemsSource = _EleveController.GetAllEleve();
            this.dgMenu.ItemsSource = _MenuController.GetAllMenu();
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

        private void btnActionClick(object sender, RoutedEventArgs e)
        {

            switch (_Action)
            {
                case "Ajouter":
                    if (((EleveDTOOut)dgEleve.SelectedItem) != null && ((MenuDTOOut)dgMenu.SelectedItem) != null)
                    { 
                    ReservationDTOIn obj = new ReservationDTOIn();
                    obj.DateReservation = (DateTime) dateReservationPicker.SelectedDate;
                    obj.IdEleve = ((EleveDTOOut)dgEleve.SelectedItem).IdEleve;
                    obj.IdMenu = ((MenuDTOOut)dgMenu.SelectedItem).IdMenu;
                    obj.Dump();
                    _ReservationController.CreateReservation(obj);
                    if (this.Left != this._FenetreMere.Left || this.Top != this._FenetreMere.Top)
                    {
                        this._FenetreMere.Left = this.Left;
                        this._FenetreMere.Top = this.Top;
                    }
                    this._FenetreMere.Visibility = Visibility.Visible;
                    this.Close();
                    } else
                    {
                        MessageBox.Show("Pas de sélection");
                    }
                    break;
                default:
                    break;
            }
        }


    }
}

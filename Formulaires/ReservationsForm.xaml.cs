using GestionCantine.Data;
using GestionCantine.Data.Models;
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
        }
    }
}

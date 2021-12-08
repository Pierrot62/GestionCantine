using GestionCantine.Controllers;
using GestionCantine.Data;
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

namespace GestionCantine.Listes
{
    /// <summary>
    /// Logique d'interaction pour Paiements.xaml
    /// </summary>
    public partial class Paiements : Window
    {
        private MainWindow FenetreMere { get; set; }
        private PaiementController _PaiementController { get; set; }

        public Paiements(MainWindow FenetreMere, GCantineContext _ctx)
        {
            InitializeComponent();
            this.FenetreMere = FenetreMere;
            this._PaiementController = new PaiementController(_ctx);
            Init();
        }

        private void Init()
        {
            dgPaiements.ItemsSource = _PaiementController.GetAllPaiement();
        }
    }
}

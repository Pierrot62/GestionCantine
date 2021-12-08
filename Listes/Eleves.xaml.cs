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
    /// Logique d'interaction pour Eleves.xaml
    /// </summary>
    public partial class Eleves : Window
    {
        private MainWindow FenetreMere { get; set; }
        private EleveController _EleveController { get; set; }

        public Eleves(MainWindow FenetreMere, GCantineContext _ctx)
        {
            InitializeComponent();
            this.FenetreMere = FenetreMere;
            this._EleveController = new EleveController(_ctx);
            Init();
        }

        private void Init()
        {
            dg.ItemsSource = _EleveController.GetAllEleve();
        }



        private void Back(object sender, RoutedEventArgs e)
        {
            if (this.Left != this.FenetreMere.Left || this.Top != this.FenetreMere.Top)
            {
                this.FenetreMere.Left = this.Left;
                this.FenetreMere.Top = this.Top;
            }
            this.FenetreMere.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}

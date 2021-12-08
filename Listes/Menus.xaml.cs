using GestionCantine.Controllers;
using GestionCantine.Data;
using GestionCantine.Data.Dtos;
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
using System.Windows.Shapes;

namespace GestionCantine.Listes
{
    /// <summary>
    /// Logique d'interaction pour Menus.xaml
    /// </summary>
    public partial class Menus : Window
    {
        private MainWindow FenetreMere { get; set; }
        private MenuController _MenuController { get; set; }

        public Menus(MainWindow FenetreMere, GCantineContext _ctx)
        {
            InitializeComponent();
            this.FenetreMere = FenetreMere;
            this._MenuController = new MenuController(_ctx);
            Init();
        }

        private void Init()
        {
            dgMenus.ItemsSource = _MenuController.GetAllMenu();
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

        private void Button_Action(object sender, RoutedEventArgs e)
        {
            MenuDTOOut menu = (MenuDTOOut)dgMenus.SelectedItem;
            string action = (string)((Button)sender).Content;

            if (menu == null && (action == "Modifier" || action == "Supprimer"))
            {
                MessageBox.Show("Pas de sélection");
            }
            else if (action == "Supprimer")
            {
                Suppression windowSupp = new Suppression();
                if ((bool)windowSupp.ShowDialog())
                {
                    _MenuController.DeleteMenu(menu.IdMenu);
                    Init();
                }
            }
            else
            {
                
            }

            public void ActionMenu(MenuDTOIn menu, string action, int id)
            {
                // On met à jour l'article en base de données
                // en fonction de l'action
                switch (action)
                {
                    case "Ajouter":
                        _MenuController.CreateMenu(menu);
                        break;
                    case "Modifier":
                        _MenuController.UpdateMenu(id, menu);
                        break;
                }

                ActualiserTableau();
            }

            private void ActualiserTableau()
            {
                dgMenus.ItemsSource = _MenuController.GetAllMenu();
            }

        }
    }
}

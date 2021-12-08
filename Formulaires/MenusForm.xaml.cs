using GestionCantine.Controllers;
using GestionCantine.Data;
using GestionCantine.Data.Dtos;
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
    /// Logique d'interaction pour MenusForm.xaml
    /// </summary>
    public partial class MenusForm : Window
    {
        Menus MainMenu;
        MenuDTOOut Menu;
        string Action;
        int Id;

        public MenusForm(string action, Menus mainMenu, MenuDTOOut menu, GCantineContext _context)
        {
            InitializeComponent();

            MainMenu = mainMenu;
            Menu = menu;
            Action = action;
            this.Id = (menu == null) ? 0 : menu.IdMenu;

            //InitPage();
        }

     
    }
}

﻿using GestionCantine.Data;
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
                    this.Visibility = Visibility.Visible;
                    break;
                case "Eleves":
                    Eleves EleveWindow = new(this, _context);
                    EleveWindow.Left = left;
                    EleveWindow.Top = top;
                    this.Visibility = Visibility.Hidden;
                    EleveWindow.ShowDialog();
                    this.Visibility = Visibility.Visible;
                    break;
                case "Paiements":
                    Paiements PaiementWindow = new(this, _context);
                    PaiementWindow.Left = left;
                    PaiementWindow.Top = top;
                    this.Visibility = Visibility.Hidden;
                    PaiementWindow.ShowDialog();
                    this.Visibility = Visibility.Visible;
                    break;
                case "Menus":
                    Menus MenuWindow = new(this, _context);
                    MenuWindow.Left = left;
                    MenuWindow.Top = top;
                    this.Visibility = Visibility.Hidden;
                    MenuWindow.ShowDialog();
                    this.Visibility = Visibility.Visible;
                    break;
                case "Modes de paiements":
                    ModeDePaiements ModePaiementWindow = new(this, _context);
                    ModePaiementWindow.Left = left;
                    ModePaiementWindow.Top = top;
                    this.Visibility = Visibility.Hidden;
                    ModePaiementWindow.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}

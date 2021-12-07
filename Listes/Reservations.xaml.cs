﻿using System;
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
    /// Logique d'interaction pour Reservations.xaml
    /// </summary>
    public partial class Reservations : Window
    {
        public MainWindow FenetreMere { get; set; }
        public Reservations(MainWindow FenetreMere)
        {
            InitializeComponent();
            this.FenetreMere = FenetreMere;
            Init();
        }

        private void Init()
        {
            
        }



        private void Back(object sender, RoutedEventArgs e)
        { 
            this.Close();
            this.FenetreMere.Visibility = Visibility.Visible;
        }
    }
}

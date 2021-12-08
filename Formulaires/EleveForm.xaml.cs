﻿using GestionCantine.Controllers;
using GestionCantine.Data.Models;
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
    /// Logique d'interaction pour EleveForm.xaml
    /// </summary>
    public partial class EleveForm : Window
    {
        private MainWindow FenetreMere { get; set; }
        private EleveController _EleveController { get; set; }

        public EleveForm()
        {
            InitializeComponent();
        }

        private void Go(object sender, RoutedEventArgs e)
        {
            string NomEleve = this.Nom.Text;
            string PrenomEleve = this.Prenom.Text;
            DateTime? DDNEleve = this.DateDeNaissance.SelectedDate;
            Eleve E = new Eleve(NomEleve, PrenomEleve, DDNEleve);
            _EleveController.CreateEleve(E);
        }

        //private void Back(object sender, RoutedEventArgs e)
        //{
        //    if (this.Left != this.FenetreMere.Left || this.Top != this.FenetreMere.Top)
        //    {
        //        this.FenetreMere.Left = this.Left;
        //        this.FenetreMere.Top = this.Top;
        //    }
        //    this.FenetreMere.Visibility = Visibility.Visible;
        //    this.Close();
        //}
    }
}

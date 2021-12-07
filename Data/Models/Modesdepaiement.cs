﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GestionCantine.Data.Models
{
    public partial class Modesdepaiement
    {
        public Modesdepaiement()
        {
            Paiements = new HashSet<Paiement>();
        }

        public int IdModeDePaiement { get; set; }
        public string LibelleModeDePaiement { get; set; }

        public virtual ICollection<Paiement> Paiements { get; set; }
    }
}

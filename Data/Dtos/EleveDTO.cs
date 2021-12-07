using GestionCantine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCantine.Data.Dtos
{
    class EleveDTOIn
    {
        public string NomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public DateTime? Ddneleve { get; set; }
    }
    class EleveDTOOut
    {
        public int IdEleve { get; set; }
        public string NomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public DateTime? Ddneleve { get; set; }
        public double SoldeEleve { get; set; }
    }

    class EleveReservationDTOOut
    {
        public int IdEleve { get; set; }
        public string NomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public DateTime? Ddneleve { get; set; }
        public double SoldeEleve { get; set; }
        public virtual List<ReservationDTOOut> Reservations { get; set; }
    }
}

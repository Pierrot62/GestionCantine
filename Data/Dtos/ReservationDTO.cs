using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCantine.Data.Dtos
{
    public class ReservationDTOOut
    {
        public int IdReservation { get; set; }
        public int? IdEleve { get; set; }
        public int? IdMenu { get; set; }
        public string LibelleMenu { get; set; }

        public string NomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public DateTime DDNEleve { get; set; }
        public DateTime? DateReservation { get; set; }

    }

    public class ReservationDTOIn
    {
        public DateTime DateReservation { get; set; }
        public int idEleve { get; set; }
        public int idMenu { get; set; }
    }

}

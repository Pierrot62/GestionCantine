using GestionCantine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCantine.Data.Dtos;

namespace GestionCantine.Data.Dtos
{
    public class MenuDTOIn
    {
        public DateTime? DateMenu { get; set; }
        public string LibelleMenu { get; set; }
        public double? PrixMenu { get; set; }
    }

    public class MenuDTOOut
    {
        public int IdMenu { get; set; }
        public DateTime? DateMenu { get; set; }
        public string LibelleMenu { get; set; }
        public double? PrixMenu { get; set; }
        public virtual List<ReservationDTOOut> Reservations { get; set; }
    }
}

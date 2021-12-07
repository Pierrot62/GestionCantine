using AutoMapper;
using GestionCantine.Data.Dtos;
using GestionCantine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCantine.Data.Profiles
{
    class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
    //        createmap Reservation => Eleve(nomEleve / prenom / DDN)

    //Reservation => Menu(Libelle)
            CreateMap<Reservation, ReservationDTOOut>();
            CreateMap<Reservation, ReservationDTOIn>();

            CreateMap<Reservation, ReservationDTOOut>().ForMember(x => x.LibelleMenu, y => y.MapFrom(z => z.Menu.LibelleMenu)).ForMember(x => x.PrixMenu, y => y.MapFrom(z => z.Menu.PrixMenu));
            CreateMap<Reservation, ReservationDTOOut>().ForMember(x => x.NomEleve, y => y.MapFrom(z => z.Eleve.NomEleve)).ForMember(x => x.PrenomEleve, y => y.MapFrom(z => z.Eleve.PrenomEleve)).ForMember(x => x.DDNEleve, y => y.MapFrom(z => z.Eleve.DDNEleve));
        }
    }
}

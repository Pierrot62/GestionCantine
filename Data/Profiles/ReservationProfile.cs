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
            CreateMap<Reservation, ReservationDTOOut>();
            CreateMap<Reservation, ReservationDTOIn>();
        }
    }
}

﻿using AutoMapper;
using GestionCantine.Data.Dtos;
using GestionCantine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCantine.Data.Profiles
{
    class PaiementProfile : Profile
    {
        public PaiementProfile()
        {
            CreateMap<PaiementDTOIn, Paiement>();
            CreateMap<Paiement, PaiementDTOIn>();
            CreateMap<Paiement, PaiementDTOOut>().ForMember(d => d.NomEleve, o => o.MapFrom(s => s.Eleve.NomEleve)).ForMember(d => d.PrenomEleve, o => o.MapFrom(s => s.Eleve.PrenomEleve)).ForMember(d => d.DDnEleve, o => o.MapFrom(s => s.Eleve.Ddneleve)).ForMember(d => d.LibelleModeDePaement, o => o.MapFrom(s => s.ModeDePaiement.LibelleModeDePaiement));
        }
    }
}

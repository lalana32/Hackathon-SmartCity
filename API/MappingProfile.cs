using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Models;
using AutoMapper;

namespace API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Appointment, GetAppointmentDTO>();
            CreateMap<AddAppointmentDTO, Appointment>();
        }
    }
}
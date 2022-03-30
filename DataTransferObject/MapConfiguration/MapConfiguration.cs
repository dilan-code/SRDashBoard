using AutoMapper;
using SrDashboard_SR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.DataTransferObject.MapConfiguration
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<Users, UserResponseDto>();
            CreateMap<UserRequestDto, Users>();
            CreateMap<Consultants, ConsultantResponseDto>();
            CreateMap<ConsultantRequestDto, Consultants>();
            CreateMap<ConsultantAccounts, ConsultantAccountResponseDto>();
            CreateMap<ConsultantAccountRequestDto, ConsultantAccounts>();
            CreateMap<Offices, OfficeResponseDto>();
            CreateMap<OfficeRequestDto, Offices>();


        }
        
    }
}

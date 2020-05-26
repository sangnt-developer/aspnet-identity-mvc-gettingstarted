using AutoMapper;
using gettingstarted_aspnet_identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gettingstarted_aspnet_identity.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(user => user.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}

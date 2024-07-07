using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public class Mapping :Profile
    {
        public Mapping()
        {
            CreateMap<User, UserViewModel>().IncludeMembers(x => x.Role).ReverseMap();
            

            CreateMap<Role, UserViewModel>().ReverseMap();
            
            CreateMap<User, AddUserViewModel>().IncludeMembers(x => x.Role).ReverseMap();
            CreateMap<Role, AddUserViewModel>().ReverseMap();

        }
    }
}

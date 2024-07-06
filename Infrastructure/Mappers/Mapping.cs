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
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserViewModel>().IncludeMembers(x => x.Role).ReverseMap();

            CreateMap<Role, UserViewModel>().ReverseMap();

            CreateMap<Role, RoleViewModel>().ReverseMap();

            CreateMap<User, AddUserViewModel>().ReverseMap();

            CreateMap<User, UpdateUserViewModel>().ReverseMap();

            CreateMap<User, DeleteUserViewModel>().ReverseMap();



        }
    }
}

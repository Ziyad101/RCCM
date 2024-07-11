using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.Request;
using Core.Entities.ViewModel.Role;
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

            CreateMap<User, AddUserViewModel>().ReverseMap();

            CreateMap<User, UpdateUserViewModel>().ReverseMap();

            CreateMap<User, DeleteUserViewModel>().ReverseMap();

            CreateMap<UserViewModel, DeleteUserViewModel>().ReverseMap();

            CreateMap<UserViewModel, UpdateUserViewModel>().ReverseMap();

            CreateMap<Role, RoleViewModel>().ReverseMap();

            CreateMap<Role, AddRoleViewModel>().ReverseMap();

            CreateMap<Role, DeleteRoleViewModel>().ReverseMap();

            CreateMap<Role, UpdateRoleViewModel>().ReverseMap();

            CreateMap<RoleViewModel, DeleteRoleViewModel>().ReverseMap();

            CreateMap<RoleViewModel, UpdateRoleViewModel>().ReverseMap();

            CreateMap<Request, RequestViewModel>().ReverseMap();

            CreateMap<Candidate,CandidateViewModel>().ReverseMap();




        }
    }
}

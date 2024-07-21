﻿using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.Major;
using Core.Entities.ViewModel.Request;
using Core.Entities.ViewModel.Role;
using Core.Entities.ViewModel.Nationality;
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
            //User Mappers
            CreateMap<User, UserViewModel>().IncludeMembers(x => x.Role).ReverseMap();
            
            CreateMap<Role, UserViewModel>().ReverseMap();

            CreateMap<User, AddUserViewModel>().ReverseMap();

            CreateMap<User, UpdateUserViewModel>().ReverseMap();

            CreateMap<User, DeleteUserViewModel>().ReverseMap();

            CreateMap<UserViewModel, DeleteUserViewModel>().ReverseMap();

            CreateMap<UserViewModel, UpdateUserViewModel>().ReverseMap();

            //Role Mappers
            CreateMap<Role, RoleViewModel>().ReverseMap();

            CreateMap<Role, AddRoleViewModel>().ReverseMap();

            CreateMap<Role, DeleteRoleViewModel>().ReverseMap();

            CreateMap<Role, UpdateRoleViewModel>().ReverseMap();

            CreateMap<RoleViewModel, DeleteRoleViewModel>().ReverseMap();

            CreateMap<RoleViewModel, UpdateRoleViewModel>().ReverseMap();

            //Request Mappers
            CreateMap<Request, RequestViewModel>().ReverseMap();

            //Candidate Mappers
            CreateMap<Candidate,CandidateViewModel>().IncludeMembers(c=>c.Major).IncludeMembers(c=>c.Nationality).ReverseMap();
            CreateMap<Major,CandidateViewModel>().ReverseMap();
            CreateMap<Nationality,CandidateViewModel>().ReverseMap();
            CreateMap<Candidate,AddCandidateViewModel>().ReverseMap();
            CreateMap<Candidate,UpdateCandidateViewModel>().ReverseMap();
            CreateMap<Candidate,DeleteCandidateViewModel>().ReverseMap();
            CreateMap<CandidateViewModel,AddCandidateViewModel>().ReverseMap();
            CreateMap<CandidateViewModel,UpdateCandidateViewModel>().ReverseMap();
            CreateMap<CandidateViewModel,DeleteCandidateViewModel>().ReverseMap();

           

            //Major Mappers
            CreateMap<Major, MajorViewModel>().ReverseMap();

            CreateMap<Major,AddMajorViewModel>().ReverseMap();

            CreateMap<Major,UpdateMajorViewModel>().ReverseMap();

            CreateMap<Major,DeleteMajorViewModel>().ReverseMap();

            CreateMap<MajorViewModel,AddMajorViewModel>().ReverseMap();

            CreateMap<MajorViewModel,UpdateMajorViewModel>().ReverseMap();

            CreateMap<MajorViewModel,DeleteMajorViewModel>().ReverseMap();

            //Nationality Mappers.

            CreateMap<Nationality, NationalityViewModel>().ReverseMap();

            CreateMap<Nationality, AddNationalityViewModel>().ReverseMap();

            CreateMap<Nationality, UpdateNationalityViewModel>().ReverseMap();

            CreateMap<Nationality, DeleteNationalityViewModel>().ReverseMap();

            CreateMap<NationalityViewModel, AddNationalityViewModel>().ReverseMap();

            CreateMap<NationalityViewModel, UpdateNationalityViewModel>().ReverseMap();

            CreateMap<NationalityViewModel, DeleteNationalityViewModel>().ReverseMap();



        }
    }
}

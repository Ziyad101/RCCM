using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Interfaces;
using Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class RoleRepo : IRoleRepo
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;


        public RoleRepo(ApplicationDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public List<RoleViewModel> GetAllRoles()
        {
            var list = new List<RoleViewModel>();
            var roles = _context.Role.ToList();
            foreach (var a in roles)
            {
                var role = new RoleViewModel
                {
                    RoleId = a.RoleId,
                    IsActive = a.IsActive,
                    RoleName = a.RoleName,
                };
                list.Add(role);
            }
            
            return list;
        }
    }
}

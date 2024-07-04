using AutoMapper;
using Core.Entities.Model;
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

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Role.ToList();
        }
    }
}

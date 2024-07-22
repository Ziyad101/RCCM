using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Role;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class RoleRepo : IRoleRepo
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;


        public RoleRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public void AddRole(AddRoleViewModel roleModel)
        {
            var roleAdd = _mapper.Map<Role>(roleModel);
            _context.Role.Add(roleAdd);
            SaveChanges();

        }

        public void DeleteRole(DeleteRoleViewModel roleModel)
        {
            var roleDelete = _mapper.Map<Role>(roleModel);
            roleDelete.IsActive = false;
            _context.Role.Update(roleDelete);
            SaveChanges();
        }

        public void EditRole(UpdateRoleViewModel roleModel)
        {
            var roleUpdate = _mapper.Map<Role>(roleModel);
            _context.Role.Update(roleUpdate);
            SaveChanges();
        }

        public List<RoleViewModel> GetAllRoles()
        {
            var roles = _context.Role.Where(r => r.IsActive).AsNoTracking().ToList();

            var roleModels = _mapper.Map<List<RoleViewModel>>(roles);

            return roleModels;
        }

        public DeleteRoleViewModel GetDeleteModel(int id)
        {
            var roleModel = GetRoleById(id);
            return _mapper.Map<DeleteRoleViewModel>(roleModel);
        }

        public UpdateRoleViewModel GetEditModel(int id)
        {
            var roleModel = GetRoleById(id);
            return _mapper.Map<UpdateRoleViewModel>(roleModel);
        }

        public RoleViewModel GetRoleById(int id)
        {
            var role = _context.Role.Where(r => r.RoleId == id).AsNoTracking().FirstOrDefault();
            var roleModel = _mapper.Map<RoleViewModel>(role);
            return roleModel;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

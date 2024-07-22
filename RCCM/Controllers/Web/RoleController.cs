using Core.Entities.Model;
using Core.Entities.ViewModel.Role;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class RoleController : Controller
    {
        private readonly IRoleRepo _roleRepo;

        public RoleController(IRoleRepo roleRepo)
        {
            _roleRepo = roleRepo;
        }
        public IActionResult Index()
        {
            try
            {
                var roles = _roleRepo.GetAllRoles();
                return View(roles);
            }
            catch (Exception)
            {

                return View(null);
            }
        }

        public IActionResult Add()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {

                throw;
            }


        }


        [HttpPost]
        public IActionResult Add(AddRoleViewModel roleModel)
        {
            try
            {
                _roleRepo.AddRole(roleModel);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Edit(int roleId)
        {
            try
            {
                var editRole = _roleRepo.GetEditModel(roleId);
                return View(editRole);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult EditRole(UpdateRoleViewModel roleModel)
        {
            try
            {
                _roleRepo.EditRole(roleModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        public IActionResult Delete(int roleId)
        {
            try
            {
                var deleteRole = _roleRepo.GetDeleteModel(roleId);
                return View(deleteRole);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult DeleteRole(DeleteRoleViewModel roleModel)
        {
            try
            {
                _roleRepo.DeleteRole(roleModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
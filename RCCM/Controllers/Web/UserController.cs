﻿using Core.Entities.ViewModel;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class UserController : Controller
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            try
            {
                var users = _userRepo.GetUsers();
                return View(users);
            }
            catch (Exception)
            {
                throw;

            }

        }

        public IActionResult Details(int id)
        {
            try
            {
                var userModel = _userRepo.GetById(id);

                if (!userModel.IsValid)
                {
                    return NotFound();
                }

                return View(userModel.Model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        }

    }


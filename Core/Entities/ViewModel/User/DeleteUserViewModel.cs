﻿using Core.Entities.ViewModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel
{
    public class DeleteUserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public RoleViewModel Role { get; set; }




    }
}

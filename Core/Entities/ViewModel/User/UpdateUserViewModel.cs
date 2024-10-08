﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.ViewModel.Role;

namespace Core.Entities.ViewModel
{
    public class UpdateUserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; } = true;
        public int RoleId { get; set; }
        public RoleViewModel Role { get; set; }
        public List<RoleViewModel> Roles { get; set; }

    }
}

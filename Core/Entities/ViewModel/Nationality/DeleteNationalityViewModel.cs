﻿using Core.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Nationality
{
    public class DeleteNationalityViewModel
    {
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



    }
}

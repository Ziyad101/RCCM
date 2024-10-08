﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CandidateStatus
{
    public class DeleteCandidateStatusViewModel
    {
        public int CandidateStatusId { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

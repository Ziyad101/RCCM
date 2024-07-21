﻿using Core.Entities.Model;
using Core.Entities.ViewModel.Nationality;
using Core.Entities.ViewModel.Major;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Candidate
{
    public class CandidateViewModel
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int NationalId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public NationalityViewModel Nationality {get; set;}
        public MajorViewModel Major {get; set;}


    }
}

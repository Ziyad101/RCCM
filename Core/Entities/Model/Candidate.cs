﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int NationalId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int RequestStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Nationality")]
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

        [ForeignKey("Major")]
        public int MajorId { get; set; }
        public Major Major { get; set; }
        public List<Experience>? Experiences { get; set; }
        public List<ExamResult>? ExamResults { get; set; }
        public Request Request { get; set; }
        public Interview? Interview { get; set; }
        public JobOffer? JobOffer { get; set; }
        public CandidateStatus CandidateStatus { get; set; }
    }
}
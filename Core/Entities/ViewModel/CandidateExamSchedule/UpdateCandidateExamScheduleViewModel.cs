﻿using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CandidateExamSchedule
{
    public class UpdateCandidateExamScheduleViewModel
    {
        public int CandidateExamScheduleId { get; set; }
        public DateTime ExamDate { get; set; }
        public bool IsActive { get; set; }
        public CandidateViewModel Candidate { get; set; }
        public ExamTypeConfViewModel ExamTypeConf { get; set; }
        public List<CandidateViewModel> Candidates { get; set; }
        public List<ExamTypeConfViewModel> ExamTypes { get; set; }
    }
}

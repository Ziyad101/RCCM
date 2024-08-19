using Core.Entities.ViewModel.CandidateExamSchedule;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CandidateExamScheduleService
    {
        private readonly ICandidateExamScheduleRepo _scheduleRepo;
        private readonly ICandidateRepo _candidateRepo;
        private readonly IExamTypeConfRepo _examTypeConfRepo;

        public CandidateExamScheduleService(ICandidateExamScheduleRepo scheduleRepo, ICandidateRepo candidateRepo, IExamTypeConfRepo examTypeConfRepo)
        {
            _scheduleRepo = scheduleRepo;
            _candidateRepo = candidateRepo;
            _examTypeConfRepo = examTypeConfRepo;
        }

        public AddCandidateExamScheduleViewModel GetAddModel()
        {
            var model = new AddCandidateExamScheduleViewModel();

            model.Candidates = _candidateRepo.GetAllCandidate();
            model.ExamTypes = _examTypeConfRepo.GetAllExamTypeConf();

            return model;
        }
    }
}

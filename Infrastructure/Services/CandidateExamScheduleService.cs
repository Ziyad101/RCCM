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

        public AddCandidateExamScheduleViewModel GetAddModel(int id = 0)
        {
            var model = new AddCandidateExamScheduleViewModel();
            if (id > 0)
            {
                var candidate = _candidateRepo.GetCandidateById(id);
                model.Candidate = candidate;
                model.Candidates = _candidateRepo.GetAllCandidate();
                model.ExamTypes = _examTypeConfRepo.GetAllExamTypeConf();
                return model;
            }

            model.Candidates = _candidateRepo.GetAllCandidate();
            model.ExamTypes = _examTypeConfRepo.GetAllExamTypeConf();

            return model;
        }

        public void AddExam(AddCandidateExamScheduleViewModel model)
        {
            _scheduleRepo.AddScheduledExam(model);
        }

        public List<CandidateExamScheduleViewModel> GetSchedules()
        {
            var models = _scheduleRepo.GetAllScheduledExams();
            
            return models;
        }
    }
}

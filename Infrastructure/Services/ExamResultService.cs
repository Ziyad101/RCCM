using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.ExamResult;
using Core.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ExamResultService
    {
        private readonly IExamResultRepo _examResultRepo;
        private readonly IExamTypeConfRepo _examTypeConfRepo;
        private readonly ICandidateRepo _candidateRepo;

        public ExamResultService(IExamResultRepo examResultRepo, IExamTypeConfRepo examTypeConfRepo, ICandidateRepo candidateRepo)
        {
            _examResultRepo = examResultRepo;
            _examTypeConfRepo = examTypeConfRepo;
            _candidateRepo = candidateRepo;
        }

        public List<ExamResultViewModel> GetAllExamResults() 
        {
            var models = _examResultRepo.GetAllExamResutls();
            return models;
        }

        public AddExamResultViewModel GetAddModel(int CandidateId,int ExamTypeConfId)
        {
            var model = new AddExamResultViewModel();
            model.Candidate = _candidateRepo.GetCandidateById(CandidateId);
            model.ExamType = _examTypeConfRepo.GetExamTypeConfById(ExamTypeConfId);
            return model;
        }

        public void AddExamResult(AddExamResultViewModel model)
        {

            model.Candidate = _candidateRepo.GetCandidateById(model.Candidate.CandidateId);
            model.ExamType = _examTypeConfRepo.GetExamTypeConfById(model.ExamType.ExamTypeConfId);
            _examResultRepo.AddExamResult(model);
        }

    }
}

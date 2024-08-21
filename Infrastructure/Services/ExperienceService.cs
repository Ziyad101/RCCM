using Core.Entities.ViewModel.Experience;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ExperienceService
    {
        private readonly ICandidateRepo _candidateRepo;
        private readonly IExperienceRepo _experienceRepo;
        private readonly IGradeRepo _gradeRepo;

        public ExperienceService(ICandidateRepo candidateRepo,IExperienceRepo experienceRepo,IGradeRepo gradeRepo)
        {
            _candidateRepo = candidateRepo;
            _experienceRepo = experienceRepo;
            _gradeRepo = gradeRepo;
        }


        public List<ExperienceViewModel> GetAllExperience()
        {
            var model = _experienceRepo.GetAllExperiences();
            return model;
        }


        public AddExperienceViewModel GetAddModel(int candidateId)
        {
            var model = new AddExperienceViewModel();
            model.Grades = _gradeRepo.GetAllGrades();
            model.Candidate = _candidateRepo.GetCandidateById(candidateId);
            return model;
        }
        public UpdateExperienceViewModel GetUpdateModel(int ExperienceId,int candidateId)
        {
            var model = _experienceRepo.GetEditModel(ExperienceId);
            model.Grades = _gradeRepo.GetAllGrades();
            model.Candidate = _candidateRepo.GetCandidateById(candidateId);
            return model;
        }
        public void AddExperience(AddExperienceViewModel model)
        {
            _experienceRepo.AddExperience(model);
            _candidateRepo.UpdateCandidateRequestStatus(model.CandidateId, 1);
        }

        public DeleteExperienceViewModel GetDeleteModel(int ExperienceId, int candidateId)
        {
            var model = _experienceRepo.GetDeleteModel(ExperienceId);
            model.Candidate = _candidateRepo.GetCandidateById(candidateId);
            return model;
        }
    }
}

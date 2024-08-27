using Core.Entities.Model;
using Core.Entities.ViewModel.Candidate;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CandidateService
    {
        private readonly ICandidateRepo _candidateRepo;
        private readonly IMajorRepo _majorRepo;
        private readonly INationalityRepo _nationalityRepo;
        private readonly ICandidateStatusRepo _candidateStatusRepo;

        public CandidateService(ICandidateRepo candidateRepo, IMajorRepo majorRepo, INationalityRepo nationalityRepo, ICandidateStatusRepo candidateStatus)
        {
            _candidateRepo = candidateRepo;
            _majorRepo = majorRepo;
            _nationalityRepo = nationalityRepo;
            _candidateStatusRepo = candidateStatus;
        }

        public GeneralCandidateViewModel GetGeneralCandidateModel()
        {
            var viewModels = _candidateRepo.GetAllCandidate();
            var majors = _majorRepo.GetAllMajors();
            var nations = _nationalityRepo.GetAllNationalitys();
            var candidateStatuses = _candidateStatusRepo.GetAllCandidateStatus();
            var model = new GeneralCandidateViewModel();
            GeneralCandidateViewModel.AllMajors = majors;
            GeneralCandidateViewModel.AllNationalities = nations;
            GeneralCandidateViewModel.AllCandidateStatuses = candidateStatuses;
            model.AllCandidate = viewModels;
            model.PopulateModels();
            return model;
        }

        public AddCandidateViewModel GetAddModel()
        {
            var model = new AddCandidateViewModel();
            model.Majors = _majorRepo.GetAllMajors();
            model.Nationalities = _nationalityRepo.GetAllNationalitys();
            model.CandidateStatuses = _candidateStatusRepo.GetAllCandidateStatus();
            return model;
        }

        public void AddCandidate(AddCandidateViewModel model)
        {
            _candidateRepo.AddCandidate(model);
        }

        public UpdateCandidateViewModel GetUpdateModel(int CandidateId)
        {
            var model = _candidateRepo.GetEditModel(CandidateId);
            model.Majors = _majorRepo.GetAllMajors();
            model.Nationalities = _nationalityRepo.GetAllNationalitys();
            model.CandidateStatuses = _candidateStatusRepo.GetAllCandidateStatus();
            return model;
        }

        public void UpdateCandidate(UpdateCandidateViewModel model)
        {
            _candidateRepo.UpdateCandidate(model);
        }
        public DeleteCandidateViewModel GetDeleteModel(int CandidateId)
        {
            var model = _candidateRepo.GetDeleteModel(CandidateId);
            return model;
        }

        public void DeleteCandidate(DeleteCandidateViewModel model)
        {
            _candidateRepo.DeleteCandidate(model);
        }
    }
}

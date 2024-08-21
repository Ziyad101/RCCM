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

       

    }
}

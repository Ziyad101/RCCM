using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.Candidate;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{   
    public class CandidateRepo : ICandidateRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CandidateRepo(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public void AddCandidate(AddCandidateViewModel candidateModel)
        {
            var candidate = _mapper.Map<Candidate>(candidateModel);
            _context.Add(candidate);
            _context.SaveChanges();
        }

        public List<CandidateViewModel> GetAllCandidate()
        {
            var allCandidates = _context.Candidate.Where(c=>c.IsActive).Include(c=>c.Nationality).Include(c=>c.Major).AsNoTracking().ToList();

            var candidateModels = new List<CandidateViewModel>();

            foreach (var candidate in allCandidates)
            {
                var candidateModel = _mapper.Map<CandidateViewModel>(candidate);
                candidateModels.Add(candidateModel);
            }
            return candidateModels;
        }


    }
}

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
            _context.Candidate.Add(candidate);
            _context.SaveChanges();
        }

        public void DeleteCandidate(DeleteCandidateViewModel candidateModel)
        {
            var candidate = _mapper.Map<Candidate>(candidateModel);
            candidate.IsActive = false;
            _context.Candidate.Update(candidate);
            _context.SaveChanges();
        }

        public List<CandidateViewModel> GetAllCandidate()
        {
            var allCandidates = _context.Candidate.Where(c => c.IsActive).Include(c => c.Nationality).Include(c => c.Major).AsNoTracking().ToList();

            var candidateModels = _mapper.Map<List<CandidateViewModel>>(allCandidates);

            return candidateModels;
        }

        public CandidateViewModel GetCandidateById(int id)
        {
            var candidate = _context.Candidate.Where(c => c.CandidateId == id).Include(c=>c.Major).Include(c=>c.Nationality).Include(c=>c.CandidateStatus).AsNoTracking().FirstOrDefault();
            var candidateModel = _mapper.Map<CandidateViewModel>(candidate);
            return candidateModel;
        }

        public DeleteCandidateViewModel GetDeleteModel(int id)
        {
            var candidate = GetCandidateById(id);
            var deleteModel = _mapper.Map<DeleteCandidateViewModel>(candidate);
            return deleteModel;

        }

        public UpdateCandidateViewModel GetEditModel(int id)
        {
            var candidate = GetCandidateById(id);
            var updateModel = _mapper.Map<UpdateCandidateViewModel>(candidate);
            return updateModel;

        }

        public void UpdateCandidate(UpdateCandidateViewModel candidateModel)
        {
            var candidate = _mapper.Map<Candidate>(candidateModel);
            var major = _context.Major.AsNoTracking().Where(m => m.MajorId == candidate.Major.MajorId).FirstOrDefault();
            var nationality = _context.Nationality.AsNoTracking().Where(n=>n.NationalityId == candidate.Nationality.NationalityId).FirstOrDefault();
            candidate.Major = major;
            candidate.Nationality = nationality;     
            _context.Candidate.Update(candidate);
            _context.SaveChanges();
        }
    }
}

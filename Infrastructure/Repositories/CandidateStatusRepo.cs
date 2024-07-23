using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.CandidateStatus;
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
    public class CandidateStatusRepo : ICandidateStatusRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CandidateStatusRepo(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void AddCandidateStatus(AddCandidateStatusViewModel candidateModel)
        {
            var candidateStatus = _mapper.Map<CandidateStatus>(candidateModel);
            _context.CandidateStatus.Add(candidateStatus);
            _context.SaveChanges();
        }

        public void DeleteCandidateStatus(DeleteCandidateStatusViewModel candidateModel)
        {
            var candidateStatus = _mapper.Map<CandidateStatus>(candidateModel);
            candidateStatus.IsActive = false;
            _context.Update(candidateStatus);
            _context.SaveChanges();
        }

        public void UpdateCandidateStatus(UpdateCandidateStatusViewModel candidateModel)
        {
            var candidateStatus = _mapper.Map<CandidateStatus>(candidateModel);
            _context.Update(candidateStatus);
            _context.SaveChanges();
        }

        public List<CandidateStatusViewModel> GetAllCandidateStatus()
        {
            var candidateStatuses  = _context.CandidateStatus.AsNoTracking().Where(c=>c.IsActive).ToList();
            var candidateStatusModels = _mapper.Map<List<CandidateStatusViewModel>>(candidateStatuses);
            return candidateStatusModels;
        }

        public CandidateStatusViewModel GetCandidateStatusById(int id)
        {
            var candidateStatus = _context.CandidateStatus.AsNoTracking().Where(c => c.CandidateStatusId == id).FirstOrDefault();
            var candidateStatusModel= _mapper.Map<CandidateStatusViewModel>(candidateStatus);
            return candidateStatusModel;
        }

        public DeleteCandidateStatusViewModel GetDeleteModel(int id)
        {
            var model = GetCandidateStatusById(id);
            return _mapper.Map<DeleteCandidateStatusViewModel>(model);
        }

        public UpdateCandidateStatusViewModel GetEditModel(int id)
        {
            var model = GetCandidateStatusById(id);
            return _mapper.Map<UpdateCandidateStatusViewModel>(model);
        }

       
    }
}

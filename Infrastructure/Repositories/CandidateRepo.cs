﻿using AutoMapper;
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
            candidate.Request = new Request
            {
                RequestStatus = 0,
                IsActive = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
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
            var allCandidates = _context.Candidate.Where(c => c.IsActive).Include(c => c.Nationality).Include(c => c.Major)
                .Include(c => c.Interviews).Include(c => c.Request)
                .Include(c => c.CandidateStatus).Include(x => x.Experiences)
                .Include(x => x.CandidateExamSchedules).AsNoTracking().ToList();
            var candidateModels = _mapper.Map<List<CandidateViewModel>>(allCandidates);
            return candidateModels;
        }

        public CandidateViewModel GetCandidateById(int id)
        {
            var candidate = _context.Candidate.Where(c => c.CandidateId == id).Include(c => c.Major)
                .Include(c => c.Nationality).Include(c => c.CandidateStatus)
                .Include(c => c.Interviews).Include(c => c.Experiences)
                .Include(c => c.CandidateExamSchedules)
                .Include(c => c.Request).AsNoTracking().FirstOrDefault();
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

            _context.Candidate.Update(candidate);
            _context.SaveChanges();
        }

        public void UpdateCandidateRequestStatus(int CandidateId, int RequestStatus)
        {
            var candidate = _context.Candidate.Where(c => c.CandidateId == CandidateId).Include(c => c.Request).AsNoTracking().FirstOrDefault();
            candidate.Request.RequestStatus = RequestStatus;
            _context.Candidate.Update(candidate);
            _context.SaveChanges();

        }
    }
}

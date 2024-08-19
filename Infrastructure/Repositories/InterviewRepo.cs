using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.Interview;
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
    public class InterviewRepo : IInterviewRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public InterviewRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void AddInterview(AddInterviewViewModel interviewModel)
        {
            var interview = _mapper.Map<Interview>(interviewModel);
            _context.Interview.Add(interview);
            _context.SaveChanges();
        }

        public void DeleteInterview(DeleteInterviewViewModel interviewModel)
        {
            var interview = _mapper.Map<Interview>(interviewModel);
            _context.Interview.Remove(interview);
            _context.SaveChanges();
        }

        public List<InterviewViewModel> GetAllInterviews()
        {
            var interviews = _context.Interview.AsNoTracking().Where(i=>i.IsActive).Include(i=>i.Candidate).ToList();
            return _mapper.Map<List<InterviewViewModel>>(interviews);
        }

        public DeleteInterviewViewModel GetDeleteModel(int id)
        {
            var interview = GetInterviewById(id);
            return _mapper.Map<DeleteInterviewViewModel>(interview);
        }

        public UpdateInterviewViewModel GetEditModel(int id)
        {
            var interview = GetInterviewById(id);
            return _mapper.Map<UpdateInterviewViewModel>(interview);
        }

        public InterviewViewModel GetInterviewById(int id)
        {
            var interview = _context.Interview.AsNoTracking().Where(i=>i.InterviewId == id).Include(i=>i.Candidate).FirstOrDefault();
            return _mapper.Map<InterviewViewModel>(interview);
        }

        public void UpdateInterview(UpdateInterviewViewModel interviewModel)
        {
            var interview = _mapper.Map<Interview>(interviewModel);
            _context.Interview.Update(interview);
            _context.SaveChanges();
        }
    }
}

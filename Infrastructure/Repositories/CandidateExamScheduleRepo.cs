using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.CandidateExamSchedule;
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
    public class CandidateExamScheduleRepo : ICandidateExamScheduleRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CandidateExamScheduleRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddScheduledExam(AddCandidateExamScheduleViewModel addModel)
        {
            var exam = _mapper.Map<CandidateExamSchedule>(addModel);
            _context.candidateExamSchedule.Add(exam);
            _context.SaveChanges();
        }

        public void DeleteScheduledExam(DeleteCandidateExamScheduleViewModel deleteModel)
        {
            var exam = _mapper.Map<CandidateExamSchedule>(deleteModel);
            exam.IsActive = false;
            _context.candidateExamSchedule.Update(exam);
            _context.SaveChanges();
        }

        public List<CandidateExamScheduleViewModel> GetAllScheduledExams()
        {
            var exams = _context.candidateExamSchedule.AsNoTracking().Where(x => x.IsActive).Include(x=>x.Candidate).Include(x=>x.ExamTypeConf).ToList();
            var models = _mapper.Map<List<CandidateExamScheduleViewModel>>(exams);
            return models;
        }

        public CandidateExamScheduleViewModel GetCandidateExamScheduleById(int id)
        {
            var exam = _context.candidateExamSchedule.AsNoTracking().Where(x => x.CandidateExamScheduleId == id).Include(x => x.Candidate).Include(x => x.ExamTypeConf).FirstOrDefault();
            var model = _mapper.Map<CandidateExamScheduleViewModel>(exam);
            return model;
        }

        public DeleteCandidateExamScheduleViewModel GetDeleteModel(int id)
        {
            var exam = GetCandidateExamScheduleById(id);
            var model = _mapper.Map<DeleteCandidateExamScheduleViewModel>(exam);
            return model;
        }

        public UpdateCandidateExamScheduleViewModel GetUpdateModel(int id)
        {
            var exam = GetCandidateExamScheduleById(id);
            var model = _mapper.Map<UpdateCandidateExamScheduleViewModel>(exam);
            return model;
        }

        public void UpdateScheduledExam(UpdateCandidateExamScheduleViewModel updateModel)
        {
            var exam = _mapper.Map<CandidateExamSchedule >(updateModel);
            _context.candidateExamSchedule.Update(exam);
            _context.SaveChanges();
        }
    }
}

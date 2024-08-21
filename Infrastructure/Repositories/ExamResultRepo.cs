using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.ExamResult;
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
    public class ExamResultRepo : IExamResultRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ExamResultRepo(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public void AddExamResult(AddExamResultViewModel addModel)
        {
            var examResult = _mapper.Map<ExamResult>(addModel);
            _context.ExamResult.Add(examResult);
            _context.SaveChanges();
        }

        public void DeleteExamResult(DeleteExamResultViewModel deleteModel)
        {
            var examResult = _mapper.Map<ExamResult>(deleteModel);
            examResult.IsActive = false;
            _context.ExamResult.Update(examResult);
            _context.SaveChanges();
        }

        public List<ExamResultViewModel> GetAllExamResutls()
        {
            var examResults = _context.ExamResult.AsNoTracking().Include(e=>e.Candidate).Include(e=>e.ExamTypeConf).ToList();
            return _mapper.Map<List<ExamResultViewModel>>(examResults);
        }

        public DeleteExamResultViewModel GetDeleteModel(int id)
        {
            var deleteModel = GetExamResultById(id);
            return _mapper.Map<DeleteExamResultViewModel>(deleteModel);
        }

        public UpdateExamResultViewModel GetEditModel(int id)
        {
            var editModel = GetExamResultById(id);
            return _mapper.Map<UpdateExamResultViewModel>(editModel);
        }

        public ExamResultViewModel GetExamResultById(int id)
        {
            var examResult = _context.ExamResult.AsNoTracking().Where(e => e.ExamResultId == id).Include(e => e.Candidate).Include(e => e.ExamTypeConf).FirstOrDefault();
            return _mapper.Map<ExamResultViewModel>(examResult);
        }

        public void UpdateExamResult(UpdateExamResultViewModel updateModel)
        {
            var examResult = _mapper.Map<ExamResult>(updateModel);
            _context.Update(examResult);
            _context.SaveChanges();
        }
    }
}

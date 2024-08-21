using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.ExamTypeConf;
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
    public class ExamTypeConfRepo : IExamTypeConfRepo
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ExamTypeConfRepo(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void AddExamTypeConf(AddExamTypeConfViewModel examTypeConfModel)
        {
            var examTypeConf = _mapper.Map<ExamTypeConf>(examTypeConfModel);
            _context.ExamTypeConf.Add(examTypeConf);
            _context.SaveChanges();
        }

        public void DeleteExamTypeConf(DeleteExamTypeConfViewModel examTypeConfModel)
        {
            var examTypeConf = _mapper.Map<ExamTypeConf>(examTypeConfModel);
            examTypeConf.IsActive = false;
            _context.ExamTypeConf.Update(examTypeConf);
            _context.SaveChanges();
        }

        public List<ExamTypeConfViewModel> GetAllExamTypeConf()
        {
            var examTypeConf = _context.ExamTypeConf.AsNoTracking().Where(e=>e.IsActive).ToList();
            return _mapper.Map<List<ExamTypeConfViewModel>>(examTypeConf);
        }

        public DeleteExamTypeConfViewModel GetDeleteModel(int id)
        {
            var viewModel = GetExamTypeConfById(id);
            return _mapper.Map<DeleteExamTypeConfViewModel>(viewModel);
        }

        public UpdateExamTypeConfViewModel GetEditModel(int id)
        {
            var viewModel = GetExamTypeConfById(id);
            return _mapper.Map<UpdateExamTypeConfViewModel>(viewModel);
        }

        public ExamTypeConfViewModel GetExamTypeConfById(int id)
        {
            var examTypeConf = _context.ExamTypeConf.Where(e=>e.ExamTypeConfId == id).AsNoTracking().FirstOrDefault();
            return _mapper.Map<ExamTypeConfViewModel>(examTypeConf);
        }

        public void UpdateExamTypeConf(UpdateExamTypeConfViewModel examTypeConfModel)
        {
            var examTypeConf = _mapper.Map<ExamTypeConf>(examTypeConfModel);
            _context.ExamTypeConf.Update(examTypeConf);
            _context.SaveChanges();
        }
    }
}

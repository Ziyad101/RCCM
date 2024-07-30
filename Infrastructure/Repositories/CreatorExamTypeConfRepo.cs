using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.CreatorExamTypeConf;
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
    public class CreatorExamTypeConfRepo : ICreatorExamTypeConfRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreatorExamTypeConfRepo(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public void AddCreator(AddCreatorExamTypeConfViewModel creatorModel)
        {
            var creator = _mapper.Map<CreatorExamTypeConf>(creatorModel);
            _context.CreatorExamTypeConf.Add(creator);
            _context.SaveChanges();
        }

        public void DeleteCreator(DeleteCreatorExamTypeConfViewModel creatorModel)
        {
            var creator = _mapper.Map<CreatorExamTypeConf>(creatorModel);
            creator.IsActive = false;
            _context.CreatorExamTypeConf.Update(creator);
            _context.SaveChanges();
        }

        public List<CreatorExamTypeConfViewModel> GetAllCreatorExam()
        {
            var creators = _context.CreatorExamTypeConf.AsNoTracking().Where(c=>c.IsActive).Include(c=>c.User).Include(c=>c.ExamTypeConf).ToList();
            var models = _mapper.Map<List<CreatorExamTypeConfViewModel>>(creators);
            return models;
        }

        public CreatorExamTypeConfViewModel GetCreatorExamById(int id)
        {
            var creator = _context.CreatorExamTypeConf.AsNoTracking().Where(c => c.AuditExamTypeConfId == id).Include(c => c.User).Include(c => c.ExamTypeConf).FirstOrDefault();
            var model = _mapper.Map<CreatorExamTypeConfViewModel>(creator);
            return model;

        }

        public DeleteCreatorExamTypeConfViewModel GetDeleteModel(int id)
        {
            var model = GetCreatorExamById(id);
            var CreatorModel = _mapper.Map<DeleteCreatorExamTypeConfViewModel>(model);
            return CreatorModel;

        }

        public UpdateCreatorExamTypeConfViewModel GetEditModel(int id)
        {
            var model = GetCreatorExamById(id);
            var CreatorModel = _mapper.Map<UpdateCreatorExamTypeConfViewModel>(model);
            return CreatorModel;
        }

        public void UpdateCreator(UpdateCreatorExamTypeConfViewModel creatorModel)
        {
            var creator = _mapper.Map<CreatorExamTypeConf>(creatorModel);
            _context.CreatorExamTypeConf.Update(creator);
            _context.SaveChanges();
        }
    }
}

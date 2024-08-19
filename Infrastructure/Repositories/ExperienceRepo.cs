using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.Experience;
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
    public class ExperienceRepo : IExperienceRepo
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public ExperienceRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddExperience(AddExperienceViewModel experienceModel)
        {
            var experience = _mapper.Map<Experience>(experienceModel);
            _context.Experience.Add(experience);
            _context.SaveChanges();
        }

        public void DeleteExperience(DeleteExperienceViewModel experienceModel)
        {
            var experience = _mapper.Map<Experience>(experienceModel);
            experience.IsActive = false;
            _context.Experience.Update(experience);
            _context.SaveChanges();
        }

        public List<ExperienceViewModel> GetAllExperiences()
        {
            var experiences = _context.Experience.AsNoTracking().Where(e=>e.IsActive).Include(e=>e.Candidate).Include(e=>e.Grade).ToList();
            var models = _mapper.Map<List<ExperienceViewModel>>(experiences);
            return models;
        }

        public DeleteExperienceViewModel GetDeleteModel(int id)
        {
            var experience = GetExperienceById(id);
            var model = _mapper.Map<DeleteExperienceViewModel>(experience);
            return model;
        }

        public UpdateExperienceViewModel GetEditModel(int id)
        {
            var experience = GetExperienceById(id);
            var model = _mapper.Map<UpdateExperienceViewModel>(experience);
            return model;
        }

        public ExperienceViewModel GetExperienceById(int id)
        {
            var experience = _context.Experience.AsNoTracking().Where(e => e.ExperienceId == id).Include(e=>e.Candidate).Include(e=>e.Grade).FirstOrDefault();
            var experienceModel = _mapper.Map<ExperienceViewModel>(experience);
            return experienceModel;
        }

        public void UpdateExperience(UpdateExperienceViewModel experienceModel)
        {
            var experience = _mapper.Map<Experience>(experienceModel);
            _context.Experience.Update(experience);
            _context.SaveChanges();
        }
    }
}

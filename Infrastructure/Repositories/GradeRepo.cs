using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Grade;
using Core.Entities.ViewModel.Role;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    public class GradeRepo : IGradeRepo
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GradeRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddGrade(AddGradeViewModel gradeModel)
        {
            var grade = _mapper.Map<Grade>(gradeModel);
            _context.Grade.Add(grade);
            _context.SaveChanges();
        }
        public void DeleteGrade(DeleteGradeViewModel gradeModel)
        {
            var gradeDelete = _mapper.Map<Grade>(gradeModel);
            gradeDelete.IsActive = false;
            _context.Grade.Update(gradeDelete);
            SaveChanges();
        }


        public List<GradeViewModel> GetAllGrades()
        {

            var grades = _context.Grade.AsNoTracking().Where(g => g.IsActive).ToList();
            var gradeModels = new List<GradeViewModel>();
            foreach (var grade in grades)
            {
                var gradeModel = _mapper.Map<GradeViewModel>(grade);
                gradeModels.Add(gradeModel);
            }
            return gradeModels;
        }

        public List<GradeViewModel> GetAllGrade()
        {
            try
            {
                var Grade = _context.Grade.AsNoTracking().Where(u => u.IsActive).ToList();

                var GradeViewModels = _mapper.Map<List<GradeViewModel>>(Grade);

                return GradeViewModels;
            }
            catch (Exception)
            {

                return new List<GradeViewModel>();
            }
        }
        public GradeViewModel GetGradeById(int id)
        {
            var grade = _context.Grade.AsNoTracking().Where(g => g.GradeId == id).FirstOrDefault();

            var gradeViewModel = _mapper.Map<GradeViewModel>(grade);

            return gradeViewModel;
        }

        public DeleteGradeViewModel GetDeleteModel(int id)
        {
            var gradeModel = GetGradeById(id);
            DeleteGradeViewModel model = _mapper.Map<DeleteGradeViewModel>(gradeModel);
            return model;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }


        public void EditGrade(UpdateGradeViewModel updateGrade)
        {
            var grade = _mapper.Map<Grade>(updateGrade);
            _context.Update(grade);
            SaveChanges();

        }

        public UpdateGradeViewModel GetEditModel(int id)
        {
            var gradeModel = GetGradeById(id);
            UpdateGradeViewModel model = _mapper.Map<UpdateGradeViewModel>(gradeModel);
            return model;
        }
    }
}

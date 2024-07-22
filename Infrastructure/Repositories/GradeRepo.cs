using AutoMapper;
using Core.Entities.ViewModel.Grade;
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
    public class GradeRepo : IGradeRepo
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GradeRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        public List<GradeViewModel> GetAllGrades()
        {

            var grades = _context.Grade.AsNoTracking().Where(g=>g.IsActive).ToList();
            var gradeModels = new List<GradeViewModel>();
            foreach(var grade in grades)
            {
                var gradeModel = _mapper.Map<GradeViewModel>(grade);
                gradeModels.Add(gradeModel);
            }
            return gradeModels;
        }
    }
}

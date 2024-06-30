  using AutoMapper;
using Core.Entities.Model;
using Core.Entities.ViewModel.Major;
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
    public class MajorRepo : IMajorRepo
    {

        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;


        public MajorRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public void AddMajor(AddMajorViewModel majorModel)
        {
            var major = _mapper.Map<Major>(majorModel);
            _context.Major.Add(major);
            SaveChanges();

        }

        public void DeleteMajor(DeleteMajorViewModel majorModel)
        {
            var major = _mapper.Map<Major>(majorModel);
            major.IsActive = false;
            _context.Major.Update(major);
            SaveChanges();
        }

        public void UpdateMajor(UpdateMajorViewModel majorModel)
        {
            var major = _mapper.Map<Major>(majorModel);
            _context.Major.Update(major);
            SaveChanges();
        }

        public List<MajorViewModel> GetAllMajors()
        {
            var majorModels = new List<MajorViewModel>();
            var majors = _context.Major.Where(m=> m.IsActive).AsNoTracking().ToList();
            foreach (var major in majors)
            {
                var majorModel = _mapper.Map<MajorViewModel>(major);
                majorModels.Add(majorModel);
            }
            return majorModels;
        }

        public DeleteMajorViewModel GetDeleteModel(int id)
        {
            var majorModel = GetMajorById(id);
            var updateModel = _mapper.Map<DeleteMajorViewModel>(majorModel);
            return updateModel;
        }

        public UpdateMajorViewModel GetEditModel(int id)
        {
            var majorModel = GetMajorById(id);
            var deleteModel = _mapper.Map<UpdateMajorViewModel>(majorModel);
            return deleteModel; ;
        }

        public MajorViewModel GetMajorById(int majorId)
        {
            var major = _context.Major.Where(m => m.MajorId == majorId).AsNoTracking().FirstOrDefault();
            var majorModel = _mapper.Map<MajorViewModel>(major);
            return majorModel;
        }

        void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

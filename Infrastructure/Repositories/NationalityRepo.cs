using AutoMapper;
using Core.Entities.Generic;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Nationality;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;





namespace Infrastructure.Repositories
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public NationalityRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<NationalityViewModel> GetAllNationalitys()
        {
            try
            {
                var nationalityViewModels = new List<NationalityViewModel>();


                var nationality = _context.Nationality.Where(n=>n.IsActive).AsNoTracking().ToList();


                foreach (var national in nationality)
                {
                    var nationalityViewModel = _mapper.Map<NationalityViewModel>(national);

                    nationalityViewModels.Add(nationalityViewModel);
                }

                return nationalityViewModels;
            }
            catch (Exception)
            {

                return new List<NationalityViewModel>{ };
            }
        }


        public NationalityViewModel GetById(int id)
        {
            try
            {
                var nationality = _context.Nationality.AsNoTracking().Where(x=>x.NationalityId==id).FirstOrDefault();

                var nationalityViewModel = _mapper.Map<NationalityViewModel>(nationality);

                return nationalityViewModel;

            }
            catch (Exception)
            {

                return new NationalityViewModel();
            }

        }

        public void AddNationality(AddNationalityViewModel nationality)
        {
            var addnationality = _mapper.Map<Nationality>(nationality);
            _context.Nationality.Add(addnationality);
            SaveChanges();
        }



        public void EditNationality(UpdateNationalityViewModel updateNationality)
        {
            var national = _mapper.Map<Nationality>(updateNationality);
            _context.Nationality.Update(national);
            SaveChanges();
        }








        public void DeleteNationality(DeleteNationalityViewModel nationalityModel)
        {
            var nationalityToDelete = _mapper.Map<Nationality>(nationalityModel);
            nationalityToDelete.IsActive = false;
            _context.Update(nationalityToDelete);
            SaveChanges();

        }


        public UpdateNationalityViewModel GetEditModel(NationalityViewModel nationalityModel)
        {
            UpdateNationalityViewModel model = _mapper.Map<UpdateNationalityViewModel>(nationalityModel);
            return model;

        }

        public DeleteNationalityViewModel GetDeleteModel(NationalityViewModel nationalityModel)
        {
            DeleteNationalityViewModel model = _mapper.Map<DeleteNationalityViewModel>(nationalityModel);

            return model;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        
    }
}

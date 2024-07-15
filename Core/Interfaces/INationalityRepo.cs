using Core.Entities.Generic;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface INationalityRepo
    {
        List<NationalityViewModel> GetAllNationalitys();
        NationalityViewModel GetById(int id);
        void EditNationality(UpdateNationalityViewModel updateNationality);
        void AddNationality(AddNationalityViewModel nationality);
        void DeleteNationality(DeleteNationalityViewModel nationalityModel);
        UpdateNationalityViewModel GetEditModel(NationalityViewModel nationalityModel);
        DeleteNationalityViewModel GetDeleteModel(NationalityViewModel nationalityModel);
    }






}

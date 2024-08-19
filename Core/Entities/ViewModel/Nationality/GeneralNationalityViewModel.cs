using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Nationality
{
    public class GeneralNationalityViewModel
    {
        public List<NationalityViewModel> AllNationality { get; set; }
        public NationalityViewModel SingleNationality { get; set; }
        public AddNationalityViewModel AddNationality { get; set; }
        public UpdateNationalityViewModel UpdateNationality { get; set; }
        public DeleteNationalityViewModel DeleteNationality { get; set; }
    }
}

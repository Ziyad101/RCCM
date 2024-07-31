using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.JobOffer
{
    public class GenrealJobOfferViewModel
    {
        public List<JobOfferViewModel> AllJobOffers { get; set; }
        public JobOfferViewModel SingleJobOffer { get; set; }
        public AddJobOfferViewModel AddJobOffer { get; set; }
        public UpdateJobOfferViewModel UpdateJobOffer { get; set; }
        public DeleteJobOfferViewModel DeleteJobOffer { get; set; }
    }
}

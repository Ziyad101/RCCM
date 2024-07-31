using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Request
{
    public class GeneralRequestViewModel
    {
        public List<RequestViewModel> AllRequest { get; set; }
        public RequestViewModel SingleRequest { get; set; }
        public AddRequestViewModel AddRequest { get; set; }
        public UpdateRequestViewModel UpdateRequest { get; set; }
        public DeleteRequestViewModel DeleteRequest { get; set; }
    }
}

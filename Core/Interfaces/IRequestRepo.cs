using Core.Entities.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRequestRepo
    {
        List<RequestViewModel> GetAllReqests();
    }
}

using Core.Entities.ViewModel.CandidateStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICandidateStatusRepo
    {
        List<CandidateStatusViewModel> GetAllCandidateStatus();
        CandidateStatusViewModel GetCandidateStatusById(int id);
        void AddCandidateStatus(AddCandidateStatusViewModel candidateStatus);
        void UpdateCandidateStatus(UpdateCandidateStatusViewModel candidateStatus);
        void DeleteCandidateStatus(DeleteCandidateStatusViewModel candidateStatus);
        UpdateCandidateStatusViewModel GetEditModel(int id);
        DeleteCandidateStatusViewModel GetDeleteModel(int id);
    }
}

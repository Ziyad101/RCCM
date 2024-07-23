using Core.Entities.Model;
using Core.Entities.ViewModel.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICandidateRepo
    {
        List<CandidateViewModel> GetAllCandidate();
        CandidateViewModel GetCandidateById(int id);
        void AddCandidate(AddCandidateViewModel candidateModel);
        void UpdateCandidate(UpdateCandidateViewModel candidateModel);
        void DeleteCandidate(DeleteCandidateViewModel candidateModel);
        UpdateCandidateViewModel GetEditModel(int id);
        DeleteCandidateViewModel GetDeleteModel(int id);

    }
}

using Core.Entities.ViewModel.Request;
using Core.Interfaces;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Infrastructure.Repositories
{
    public class RequestRepo : IRequestRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RequestRepo(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<RequestViewModel> GetAllReqests()
        {
            var allRoles = _context.Request.Where(r=>r.IsActive).AsNoTracking().ToList();
            _context.Request.Add(new Core.Entities.Model.Request
            {
                IsActive = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                RequestStatus = 2
            });
            _context.Request.Add(new Core.Entities.Model.Request
            {
                IsActive = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                RequestStatus = 3
            });
            _context.SaveChanges();

            var requestModels = new List<RequestViewModel>();
            foreach (var role in allRoles)
            {

                var rle = _mapper.Map<RequestViewModel>(role);
                requestModels.Add(rle);
            }
            
            return requestModels;
        }
    }
}

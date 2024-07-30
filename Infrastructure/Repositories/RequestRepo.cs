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

        public RequestRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<RequestViewModel> GetAllReqests()
        {
            throw new NotImplementedException();
        }
    }
}

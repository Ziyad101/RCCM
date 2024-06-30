using Core.Entities.ViewModel;
using Core.Interfaces;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HomeRepo : IHomeRepo
    {
        private readonly ApplicationDbContext _context;

        public HomeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public DemoViewModel getViewModeltest()
        {
            var viewModel = new DemoViewModel();
            viewModel.test = "ayman";

            return viewModel;
        }

    }
}

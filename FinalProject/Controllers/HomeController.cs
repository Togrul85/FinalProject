
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()  //fronttoback reletions 11:26
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Rtelecoms =_appDbContext.Rtelecoms.ToList();
            homeVM.Expensives = _appDbContext.Expensives.ToList();
            return View(homeVM);
        }
        
       
    }
}
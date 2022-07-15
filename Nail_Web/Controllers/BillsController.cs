using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nail_Web.Data;
using Nail_Web.Models;

namespace Web.Controllers
{
    public class BillsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bills
        public IActionResult Index()
        {
             return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        
    }
}

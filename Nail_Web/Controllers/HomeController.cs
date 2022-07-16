using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Nail_Web.Models;
using Nail_Web.Data;
using Microsoft.AspNetCore.Html;

namespace Nail_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            
            ViewData["TrendingList"] =new HtmlString(CreateTrendingList(8));
            return View();
        }

        // GET: Home/Contact
        public IActionResult Contact()
        {
            return View("Contact");
        }

        // GET: Home/News
        public IActionResult News()
        {
            return View("News");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private int GetRating(int? Prd_Id)
        {
            int? rate = 0;
            int count = 0;
            if (_context.Feedback != null)
            {
                foreach (var item in _context.Feedback.ToList())
                {
                    if (item.Fdb_PrdId == Prd_Id)
                    {
                        count++;
                        rate += item.Fdb_Rating;
                    }
                }
                if (count == 0) return 0;
                else return (int)rate / count;
            }
            else return 0;
        }

        private int getMinUnitPrice(int? Prd_Id)
        {
            List<int> priceList = new List<int>();
            if (_context.ProductColor != null)
            {
                foreach (var item in _context.ProductColor.ToList())
                {
                    if (item.Clr_PrdId == Prd_Id)
                    {
                        if (item.Clr_UnitPrice != null) priceList.Add((int)item.Clr_UnitPrice);
                    }
                }
                return priceList.AsQueryable().DefaultIfEmpty().Min();
            }
            else return 0;
        }

        private double getMaxPercentUp(int? Prd_Id)
        {
            List<double> percentUPList = new List<double>();

            if (_context.ProductColor != null)
            {
                foreach (var item in _context.ProductColor.ToList())
                {
                    if (item.Clr_PrdId == Prd_Id)
                    {
                        if (item.Clr_UnitPrice == getMinUnitPrice(Prd_Id))
                        {
                            if (item.Clr_PercentUp != null) percentUPList.Add((double)item.Clr_PercentUp);
                        }
                    }
                }
                return percentUPList.AsQueryable().DefaultIfEmpty().Max();
            }
            else return 0;
        }

        public int getRealPrice(int UnitPrice, double PercentUp)
        {
            return (int)((1-PercentUp) * UnitPrice);
        }

        public string CreateTrendingList(int Limit)
        {
            string code = "";
            Random rnd = new Random();
            if (_context.Product != null)
            {
                for (int i = 0; i < Limit; i++)
                {
                    var item = _context.Product.ToList()[rnd.Next(_context.Product.ToList().Count())];

                    code += "<div class=\"col-md-3 col-6\">";
                    code += "<div class=\"icon-produce position-absolute d-block\">";
                    code += "<div class=\"w3-container\">";
                    code += "<button class=\"icon-eye border-0 bg-white mt-3 w3-animate-right\">";
                    code += "<i class=\"bi bi-eye\"></i>";
                    code += "</button>";
                    code += "</div>";
                    code += "<div class=\"w3-container\">";
                    code += "<button class=\"icon-heart border-0 bg-white mt-1 w3-animate-right\">";
                    code += "<i class= \"bi bi-heart\" ></i>";
                    code += "</button>";
                    code += "</div>";
                    code += "</div>";
                    code += "<div class=\"container\">";
                    code += "<a asp-action=\"ProductDetail\" asp-route-id=\"" + item.Prd_Id + "\">";
                    code += "<img src=\"" + item.Prd_AvaUrl + "\" alt=\"Nnail\" class=\"image\">";
                    code += "<div class=\"overlay\">";
                    code += "<img src =\"" + item.Prd_AvaUrl + " \" alt = \"Nnail\" >";
                    code += "</div>";
                    code += "</a>";
                    code += "</div>";
                    code += "<div class=\"icon-start d-flex justify-content-center\">";
                    for (var j = 0; j < GetRating(item.Prd_Id); j++)
                    {
                        code += "< i class=\"bi-star-fill text-warning mx-1\"></i>";
                    }
                    code += "</div>";
                    code += "<div class=\"name-product mt-2 text-center\">";
                    code += "<span class=\"name text-dark fw-normal\">" + item.Prd_Name + "...</span>";
                    code += "<div class=\"price mt-4\">";
                    code += "<span class=\"old-price fw-normal text-decoration-line-through\">";
                    code += getMinUnitPrice(item.Prd_Id) + "đ";
                    code += "</span>";
                    code += "<span class=\"new-price ms-2\">";
                    code += getRealPrice(getMinUnitPrice(item.Prd_Id), getMaxPercentUp(item.Prd_Id)) + "đ";
                    code += "</span>";
                    code += "</div>";
                    code += "<div class=\"w3-container mb-5\">";
                    code += "<button class= \"w3-center w3-animate-bottom add-to-cart border-0 position-absolute ms-5\" >";
                    code += "<a class= \"text-decoration-none text-uppercase text-white\" asp-controller = \"Bills\" asp-action = \"Cart\" asp-route-id=\"" + item.Prd_Id + "\" > add to cart</a></button>";
                    code += "</div>";
                    code += "</div>";
                    code += "</div>";
                }
        }
        return code; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nail_Web.Data;
using Nail_Web.Models;

namespace Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            @ViewData["AllList"] = new HtmlString(CreateAllList());
              return _context.Product != null ? 
                          View(await _context.Product.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Product'  is null.");
        }

        public IActionResult NewProduct ()
        {
            return View();
        }

        // GET: Products/Details/5
        public async Task<IActionResult> ProductDetail(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Prd_Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        private int GetRating (int? Prd_Id)
        {
            int? rate = 0;
            int count = 0;
            if (_context.Feedback != null)
            {
                foreach (var item in _context.Feedback.ToList())
                {
                    if(item.Fdb_PrdId == Prd_Id)
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

        private List<Product> NewestList ()
        {
            List<Product> products = new List<Product> ();
            //todo
            return products;
        }

        private List<Product> HotList()
        {
            List<Product> products = new List<Product>();
            //todo
            return products;
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

        public string CreateAllList()
        {
            string code = "";
            Random rnd = new Random();
            if (_context.Product != null)
            {
                foreach (var item in _context.Product.ToList())
                {
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

        public void CreateFoundList(string Keyword)
        {

        }
        public void CreateLastestList(int Limit)
        {

        }

    }
}

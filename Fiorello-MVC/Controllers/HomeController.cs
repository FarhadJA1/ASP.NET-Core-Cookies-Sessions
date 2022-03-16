using Fiorello_MVC.Data;
using Fiorello_MVC.Models;
using Fiorello_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            /*HttpContext.Session.SetString("name","Ferhad");
            Response.Cookies.Append("surname", "Azadaliyev", new CookieOptions {
                MaxAge = TimeSpan.FromSeconds(20)
            });*/

            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.ToListAsync();
            List<Product> products = await _context.Products
                .Include(m=>m.Category)
                .Include(m=>m.Images)                
                .ToListAsync();
            ExpertsText expertsText = await _context.ExpertsTexts.FirstOrDefaultAsync();
            List<Experts> experts = await _context.Experts.ToListAsync();
            BlogHeader blogHeader = await _context.BlogHeaders.FirstOrDefaultAsync();
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            List<Testimone> testimones = await _context.Testimones.ToListAsync();
            List<Instagram> instagrams = await _context.Instagrams.ToListAsync();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                Detail = detail,
                Categories = categories,
                Products = products,
                ExpertsText = expertsText,
                Experts=experts,
                BlogHeader=blogHeader,
                Blogs=blogs,
                Testimonials=testimones,
                Instagrams=instagrams
                
            };
            return View(homeVM);
        }
        /*public IActionResult Test()
        {
            var session = HttpContext.Session.GetString("name");
            var cookie = Request.Cookies["surname"];
            if (session == null) return NotFound();
            return Json("Name: " + session + " " + cookie);
        }*/
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id is null) return NotFound();
            Product dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct == null) return BadRequest();
            List<BasketVM> basket;
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }
            basket.Add(new BasketVM
            {
                Id = dbProduct.Id,
                Count = 1
            });
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            return Json(id);
        }
    }
}

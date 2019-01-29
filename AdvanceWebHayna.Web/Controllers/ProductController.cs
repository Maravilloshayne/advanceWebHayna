using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebHayna.Web.Infrastructures.Data.Helpers;
using AdvanceWebHayna.Web.Infrastructures.Data.Models;
using AdvanceWebHayna.Web.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceWebHayna.Web.Controllers
{
    public class ProductController : Controller
    {

        private readonly DefaultDbContext _context;
        public ProductController(DefaultDbContext context)
        {

            _context = context;
        }

        [HttpGet, Route("home/products/index")]
        [HttpGet, Route("home/products")]
        public IActionResult Index(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            Page<Product> result = new Page<Product>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Product> prodQuery = (IQueryable<Product>)this._context.Products;

            if (string.IsNullOrEmpty(keyword) == false)
            {
                prodQuery = prodQuery.Where(u => u.Name.ToLower().Contains(keyword.ToLower()));
            }

            long queryCount = prodQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Product> users = prodQuery.ToList();

            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Products = result
            });
        }


        [HttpGet, Route("home/products/create")]
        [HttpGet, Route("products/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("home/products/create")]
        [HttpPost, Route("products/create")]
        public IActionResult Create(CreateProductViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                IsPublished = true,
                PostExpiry = model.PostExpiry,
            };

            this._context.Products.Add(product);
            this._context.SaveChanges();

            return View();
        }

        [HttpPost, Route("manage/products/unpublish")]
        [HttpPost, Route("products/unpublish")]
        public IActionResult Unpublish(ProductIdViewModel model)
        {
            var product = this._context.Products.FirstOrDefault(p => p.Id == model.Id);

            if (product != null)
            {
                product.IsPublished = false;
                this._context.Products.Update(product);
                this._context.SaveChanges();
                return Ok();
            }

            return null;
        }

        [HttpPost, Route("manage/products/publish")]
        [HttpPost, Route("products/publish")]
        public IActionResult Publish(ProductIdViewModel model)
        {
            var product = this._context.Products.FirstOrDefault(p => p.Id == model.Id);

            if (product != null)
            {
                product.IsPublished = true;
                this._context.Products.Update(product);
                this._context.SaveChanges();
                return Ok();
            }

            return null;
        }

        [HttpGet, Route("/home/products/update-title/{productId}")]
        public IActionResult UpdateTitle(Guid? productId)
        {
            var products = this._context.Products.FirstOrDefault(p => p.Id == productId);

            if (products != null)
            {
                var model = new UpdateTitleViewModel()
                {
                    Id = products.Id,
                    Description = products.Description,
                    Name = products.Name,
                    PostExpiry = products.PostExpiry

                };

                return View(model);
            }

            return RedirectToAction("Create");
        }

        [HttpPost, Route("/home/products/update-title/")]
        public IActionResult UpdateTitle(UpdateTitleViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var product = this._context.Products.FirstOrDefault(p => p.Id == model.Id);

            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.PostExpiry = model.PostExpiry;


                this._context.Products.Update(product);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet, Route("/home/products/update-description/{productId}")]
        public IActionResult UpdateDescription(Guid? productId)
        {
            var product = this._context.Categories.FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                return View(new UpdateDescriptionViewModel()
                {
                    CategoryId = product.Id,
                    Name = product.Name,
                    Description = product.Description
                });
            }

            return RedirectToAction("Index");
        }

        [HttpPost, Route("/home/products/update-description/")]
        public IActionResult UpdateDescription(UpdateDescriptionViewModel model)
        {
            var product = this._context.Products.FirstOrDefault(p => p.Id == model.CategoryId);

            if (product != null)
            {
                product.Description = model.Description;
                product.Timestamp = DateTime.UtcNow;

                this._context.Products.Update(product);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
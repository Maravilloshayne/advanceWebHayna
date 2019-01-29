using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebHayna.Web.Infrastructures.Data.Helpers;
using AdvanceWebHayna.Web.Infrastructures.Data.Models;
using AdvanceWebHayna.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceWebHayna.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DefaultDbContext _context;
        public CategoryController(DefaultDbContext context)
        {

            _context = context;
        }

        [HttpGet, Route("home/categories/index")]
        [HttpGet, Route("home/categories")]
        public IActionResult Index(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            Page<Category> result = new Page<Category>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Category> catQuery = (IQueryable<Category>)this._context.Categories;

            if (string.IsNullOrEmpty(keyword) == false)
            {
                catQuery = catQuery.Where(u => u.Name.ToLower().Contains(keyword.ToLower()));
            }

            long queryCount = catQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Category> users = catQuery.ToList();

            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Categories = result
            });
        }

        [HttpGet, Route("home/categories/create")]
        [HttpGet, Route("categories/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("home/categories/create")]
        [HttpPost, Route("categories/create")]
        public IActionResult Create(CreateCategoryViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Category category = new Category()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                IsPublished = true,
                PostExpiry = model.PostExpiry,
                Price = model.Price
            };

            this._context.Categories.Add(category);
            this._context.SaveChanges();

            return View();

        }

        [HttpPost, Route("home/categories/unpublish")]
        [HttpPost, Route("categories/unpublish")]
        public IActionResult Unpublish(CategoryIdViewModel model)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == model.Id);

            if (category != null)
            {
                category.IsPublished = false;
                this._context.Categories.Update(category);
                this._context.SaveChanges();
                return Ok();
            }

            return null;
        }

        [HttpPost, Route("home/categories/publish")]
        [HttpPost, Route("categories/publish")]
        public IActionResult Publish(CategoryIdViewModel model)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == model.Id);

            if (category != null)
            {
                category.IsPublished = true;
                this._context.Categories.Update(category);
                this._context.SaveChanges();
                return Ok();
            }

            return null;
        }

        [HttpGet, Route("/home/categories/update-title/{categoryId}")]
        public IActionResult UpdateTitle(Guid? categoryId)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == categoryId);

            if (category != null)
            {
                var model = new UpdateTitleViewModel()
                {
                    Id = category.Id,
                    Description = category.Description,
                    Name = category.Name,
                    PostExpiry = category.PostExpiry

                };

                return View(model);
            }

            return RedirectToAction("Create");
        }

        [HttpPost, Route("/home/categories/update-title")]
        public IActionResult UpdateTitle(UpdateTitleViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var category = this._context.Categories.FirstOrDefault(p => p.Id == model.Id);

            if (category != null)
            {
                category.Name = model.Name;
                category.Description = model.Description;
                category.PostExpiry = model.PostExpiry;


                this._context.Categories.Update(category);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet, Route("/home/categories/update-description/{categoryId}")]
        public IActionResult UpdateDescription(Guid? categoryId)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == categoryId);

            if (category != null)
            {
                return View(new UpdateDescriptionViewModel()
                {
                    ParentId = category.Id,
                    Name = category.Name,
                    Description = category.Description
                });
            }

            return RedirectToAction("Index");
        }

        [HttpPost, Route("/home/categories/update-description/")]
        public IActionResult UpdateDescription(UpdateDescriptionViewModel model)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == model.ParentId);

            if (category != null)
            {
                category.Name = model.Name;
                category.Description = model.Description;

                category.Timestamp = DateTime.UtcNow;

                this._context.Categories.Update(category);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }



        [HttpGet, Route("/home/categories/update-price/{categoryId}")]
        public IActionResult UpdatePrice(Guid? categoryId)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == categoryId);

            if (category != null)
            {
                return View(new UpdatePriceViewModel()
                {
                    ParentId = category.Id,
                    Price = category.Price,
                    Name = category.Name


                });
            }

            return RedirectToAction("Index");
        }

        [HttpPost, Route("/home/categories/update-price/")]
        public IActionResult UpdatePrice(UpdatePriceViewModel model)
        {
            var category = this._context.Categories.FirstOrDefault(p => p.Id == model.ParentId);

            if (category != null)
            {
                category.Price = model.Price;
                category.Name = model.Name;
                category.Timestamp = DateTime.UtcNow;

                this._context.Categories.Update(category);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
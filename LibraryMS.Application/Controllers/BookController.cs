using AutoMapper;
using LibraryMS.Application.ViewModels;
using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Repositories;
using LibraryMS.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMS.Application.Controllers
{
    public class BookController : Controller
    {
		private readonly IBookCategoryRepository categoryRepo;
		private readonly IMapper autoMapper;

        #region Constructor
        public BookController(
    IBookCategoryRepository _categoryRepo,
    IMapper _autoMapper)
        {
            categoryRepo = _categoryRepo;
            autoMapper = _autoMapper;
        } 
        #endregion

        #region Book Category Operations
        public async Task<IActionResult> AddCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCategory(BookCategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = autoMapper.Map<BookCategory>(categoryViewModel);
                var exists = await categoryRepo.getCategoryByName(category.Name);
                if (exists != null)
                {
                    ModelState.AddModelError(string.Empty, "Category already exists!");
                    return View(categoryViewModel);
                }
                await categoryRepo.AddAsync(category);
                return View(categoryViewModel);
            }
            return View();
        }
        #endregion

        #region Book Operations
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AddBook()
        {
            var categories = await categoryRepo.GetAllAsync();
            if (categories != null)
            {
                ViewBag.BookCategories = categories;
                return View();
            }
            return View(nameof(Index));
        }
        #endregion

    }
}

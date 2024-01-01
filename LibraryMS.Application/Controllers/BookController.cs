using AutoMapper;
using LibraryMS.Application.ViewModels;
using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Repositories;
using LibraryMS.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryMS.Application.Controllers
{
	public class BookController : Controller
	{
		private const string INDEX_MSG_KEY = "MsgForIndex";
		private readonly IBookCategoryRepository categoryRepository;
		private readonly IBookRepository bookRepository;
		private readonly IMapper autoMapper;

		#region Constructor
		public BookController(
			IBookCategoryRepository _categoryRepository,
			IBookRepository _bookRepository,
			IMapper _autoMapper)
		{
			categoryRepository = _categoryRepository;
			bookRepository = _bookRepository;
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
				var exists = await categoryRepository.getCategoryByName(category.Name);
				if (exists != null)
				{
					ModelState.AddModelError(string.Empty, "Category already exists!");
					return View(categoryViewModel);
				}
				await categoryRepository.AddAsync(category);
				return View(categoryViewModel);
			}
			return View();
		}
		#endregion

		#region Book Operations
		public async Task<IActionResult> Index()
		{
			ViewBag.Books = await bookRepository.GetAllAsync();
			return View();
		}

		public async Task<IActionResult> AddBook()
		{
			var categories = await categoryRepository.GetAllAsync();
			if (categories != null)
			{
				ViewData["BookCategories"] = categories;
				return View();
			}
			return View(nameof(Index));
		}

		[HttpPost]
		public async Task<IActionResult> AddBook(BookViewModel bookViewModel)
		{
			if (bookViewModel.CategoryId <= 0 && ModelState.ErrorCount <= 0) 
				ModelState.AddModelError(string.Empty, "Select a book category");

			if (ModelState.IsValid)
			{
				var book = autoMapper.Map<Book>(bookViewModel);
				await bookRepository.AddAsync(book);
				ViewData[INDEX_MSG_KEY] = $"Book {book.Name} added successfully.";
				return RedirectToAction(nameof(Index));
			}
			ViewBag.BookCategories = await categoryRepository.GetAllAsync();
			return View(bookViewModel);
		}
		#endregion

	}
}

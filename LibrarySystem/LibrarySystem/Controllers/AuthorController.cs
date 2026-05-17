using LibrarySystem.Business.AuthorBusiness;
using LibrarySystem.Dtos;
using LibrarySystem.Shared.AuthorData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibrarySystem.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorBusiness _authorBusiness;
        public AuthorController(IAuthorBusiness authorBusiness)
        {
            _authorBusiness = authorBusiness;
        }

        public async Task<IActionResult> Index()
        {
            var authorList = await _authorBusiness.GetAuthorList();
            return View(authorList);
        }

        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAuthor(AuthorDetails author)
        {
            if (ModelState.IsValid)
            {
                //if (book.Name != "hello")
                //{
                //    ModelState.AddModelError("Name", "Hello custom error");
                //}
                bool isAdded = await _authorBusiness.AddAuthor(author);
                if (isAdded)
                {
                    TempData["isSuccess"] = "YES";
                    TempData["Message"] = "Author added successfully";
                }
                else
                {
                    TempData["isSuccess"] = "YES";
                    TempData["Message"] = "Failed to add author";
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(author);
            }
        }


        public async Task<IActionResult> EditAuthor(int id)
        {
            var authorDetails = await _authorBusiness.GetAuthorDetails(id);
            if (authorDetails == null)
            {
                return NotFound();
            }

            return View(authorDetails);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAuthor(AuthorDetails author)
        {
            if (ModelState.IsValid)
            {
                var details = await _authorBusiness.EditAuthor(author);
                if (details)
                {
                    TempData["isSuccess"] = "YES";
                    TempData["Message"] = "Author details updated successfully";
                }
                else
                {
                    TempData["isSuccess"] = "NO";
                    TempData["Message"] = "Failed to update author details";
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(author);
            }
        }
    }
}

    //public async Task<IActionResult> FormFields()
    //{
    //    FormFields formFields = new FormFields();
    //    var bookList = await _authorBusiness.GetAuthorList();
    //    formFields. = authorList.Select(b => new SelectListItem
    //    {
    //        Value = b.AuthorId.ToString(),
    //        Text = b.Name
    //    }).ToList();

//    return View(formFields);
//}







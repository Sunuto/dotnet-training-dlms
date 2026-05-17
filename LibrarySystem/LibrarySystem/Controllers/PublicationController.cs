using LibrarySystem.Business.PublicationBusiness;
using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.PublicationData;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class PublicationController : Controller
    {

        private readonly IPublicationBusiness _publicationBusiness;
        public PublicationController(IPublicationBusiness publicationBusiness)
        {
            _publicationBusiness = publicationBusiness;
        }


        public IActionResult Index()
        {
            var publicationList = _publicationBusiness.GetPublicationList();
            return View();
        }

        public async Task<IActionResult> AddPublication(PublicationDetails publication) {

            if (ModelState.IsValid)
            {
                //if (book.Name != "hello")
                //{
                //    ModelState.AddModelError("Name", "Hello custom error");
                //}
                bool isAdded = await _publicationBusiness.AddPublication(publication);
                if (isAdded)
                {
                    TempData["isSuccess"] = "YES";
                    TempData["Message"] = "Publication added successfully";
                }
                else
                {
                    TempData["isSuccess"] = "YES";
                    TempData["Message"] = "Failed to add publication";
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(publication);
            }
        }

    }
}


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


        public async Task<IActionResult> Index(string searchText)
        {
            var publicationList = await _publicationBusiness.GetPublicationList(searchText);
            return View(publicationList);
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
                return RedirectToAction("AddPublication");
            }
            else
            {
                return View(publication);
            }
        }

        public async  Task<IActionResult> EditPublication(string id)
        {
            var publicationId = Convert.ToInt32(id);
            var publicationDetails = await _publicationBusiness.GetPublicationDetails(publicationId);
            return View(publicationDetails);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPublication(PublicationDetails publication)
        {
            if (ModelState.IsValid)
            {
                var details = await _publicationBusiness.EditPublication(publication);
                if (details)
                {
                    TempData["Message"] = "Publication details updated successfully";
                }
                else
                {
                    TempData["isSuccess"] = "NO";
                    TempData["Message"] = "Failed to update Publication details";
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


using CoursEnC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursEnC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TutoController : Controller
    {

        // GET : Tuto/GetAllTuto
        [HttpGet("GetAllTuto")]

        public ActionResult<List<Tuto>> GetAllTuto()
        {
            
            return Ok();
        }

        // POST: TutoController/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: TutoController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: TutoController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

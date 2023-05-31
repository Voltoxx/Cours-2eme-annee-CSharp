using CoursEnC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoursEnC.Context;

namespace CoursEnC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TutoController : Controller
    {

        private readonly AppDBContext context;

        public TutoController(AppDBContext context)
        {
            this.context = context;
        }



        // GET : Tuto/GetAllTuto
        [HttpGet("GetAllTuto")]

        public ActionResult<List<Tuto>> GetAllTuto()
        {
            return context.tuto.ToList();
        }

        // GET : Tuto/GetOneTuto
        [HttpGet("GetOne/{id}")]

        public ActionResult<Tuto> GetOneTuto(int id)
        {
            Tuto tuto = context.tuto.Find(id);
            if (tuto != null)
            {
                return tuto;
            }
            return NotFound("Pas la bonne ID bg");
        }

        
        
    }
}

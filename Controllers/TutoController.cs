using CoursEnC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoursEnC.Context;
using Microsoft.EntityFrameworkCore;

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

        // POST : Tuto/CreateOneTuto
        [HttpPost("CreateOneTuto")]

        public ActionResult<Tuto> CreateOneTuto(Tuto tuto)
        {
            context.tuto.Add(tuto);
            context.SaveChanges();
            return Ok();
        }

        // PUT : Tuto/UpdateOneTuto
        [HttpPut("UpdateOneTuto")]

        public ActionResult<Tuto> UpdateOneTuto(Tuto tuto)
        {
            context.Entry(tuto).State = EntityState.Modified;
            context.SaveChanges();
            return tuto;
        }

        // DELETE : Tuto/DeleteOneTuto
        [HttpDelete("DeleteOneTuto/{id}")]
        public ActionResult<Tuto> DeleteOneTuto(int id)
        {
            context.tuto.Remove(context.tuto.Find(id));
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeleteOneTuto")]
        public ActionResult<Tuto> DeleteOneTuto(Tuto tuto)
        {
            context.tuto.Remove(tuto);
            context.SaveChanges();
            return Ok();
        }


    }
}

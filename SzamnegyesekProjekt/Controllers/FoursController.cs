using Microsoft.AspNetCore.Mvc;
using SzamnegyesekProjekt.Models;

namespace SzamnegyesekProjekt.Controllers
{
    [Route("api/[controller]")]
    public class FoursController : Controller
    {
        public SzamokContext Context { get; set; }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(Context.Szamnegyeseks);
        }
        [HttpGet("/api/[controller]/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(Context.Szamnegyeseks.Where(sz =>sz.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public async Task<IActionResult> AddNew(int[] numbers)
        {
            Szamnegyesek szam = new Szamnegyesek();
            szam.Szamok = numbers;
            szam.Id = new Guid();
            if(Context.Szamnegyeseks.Where(sz =>sz.Id == szam.Id).Count() > 0 || szam.Szamok.Length != 4)
            {
                return BadRequest();
            }
            else
            {
                Context.Szamnegyeseks.Add(szam);
            }
            Context.SaveChanges();
            return Ok(Context.Szamnegyeseks);
        }
    }
}

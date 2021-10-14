using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_KamilaArzadum.Data;
using Parcial2_KamilaArzadum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_KamilaArzadum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RandomController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Suerte>> GetSuerte()
        {

            var list = await _context.Suerte.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var cancion = list[index];

            if (cancion == null)
            {
                return NoContent();
            }

            return cancion;
        }
    }

}

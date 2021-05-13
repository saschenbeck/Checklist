using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checklist.Models;
using Checklist.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checklist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimesController : ControllerBase
    {
        public AnimesController(JsonFileAnimeService animeService)
        {
            this.AnimeService = animeService;
        }

        public JsonFileAnimeService AnimeService { get; }
        [HttpGet]
        public IEnumerable<Anime> Get() 
        {
            return AnimeService.GetAnimes();
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] string AnimeId, int Rating)
        {
            AnimeService.AddRating(AnimeId, Rating);
            return Ok();
        }
    }
}

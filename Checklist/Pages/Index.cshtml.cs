using Checklist.Models;
using Checklist.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checklist.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileAnimeService AnimeService;
        public IEnumerable<Anime> Animes { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileAnimeService animeService)
        {
            _logger = logger;
            AnimeService = animeService;
        }

        public void OnGet()
        {
            Animes = AnimeService.GetAnimes();
        }
    }
}

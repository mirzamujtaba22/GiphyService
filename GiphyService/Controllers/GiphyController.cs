using Giphy.Libs.GiphyService;
using Microsoft.AspNetCore.Mvc;

namespace GiphyService.Controllers
{
    public class GiphyController : Controller
    {
        private readonly IGiphyService giphyService;

        public GiphyController(IGiphyService _giphyService)
        {
                    giphyService = _giphyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> GetRandomGif(string searchCriteria)
        //{
        //    //var result = await giphyService.GetRandomGifBasedOnSearchCriteria(searchCriteria);
        //    //return Ok(result);
        //}
    }
}

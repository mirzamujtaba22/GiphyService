using Giphy.Libs.GifRandomGif;
using Giphy.Libs.Model;

namespace Giphy.Libs.GiphyService
{
    public class GiphyService:IRandomGif
    {
        private readonly IRandomGif _getRandomGif;
        public GiphyService(IRandomGif getRandomGif)
        {
            _getRandomGif = getRandomGif;
        }
        //public async Task<GiphyModel> GetRandomGifBasedOnSearchCriteria(string searchCriteria)
        //{

        //    //return await _getRandomGif.ReturnRandomGifBasedOnTag(searchCriteria);
        //}
    }
}
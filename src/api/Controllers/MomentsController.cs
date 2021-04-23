using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mock_marketplace_content.Controllers
{
    [ApiController]
    [Route("api/moments")]
    public class MomentsController : ControllerBase
    {
        private static readonly string[] _moments =
        {
            "https://jane.com/blog/aries-style-guide/",
            "https://jane.com/blog/helgenbargenflergenflurfennerfen/",
            "https://jane.com/blog/lemon-flower-fizz-trader-joes-hack/"
        };

        private static readonly string[] _momentImages = 
        {
            "https://jane.com/blog/wp-content/uploads/2021/04/Content-_-Horoscope-Fashion-Aries_FeatureImage_800x1200.jpg",
            "https://jane.com/blog/wp-content/uploads/2021/04/CONTENT-Helgenbargenflergenflurfennerfen_FeatureImage_800x1200-1.jpg",
            "https://jane.com/blog/wp-content/uploads/2021/04/CONTENT-Lemon-Flower-Fizz-Trader-Joes-Hack_FeatureImage_800x1200.jpg"
        };

        private static readonly string[][] _categories =
        {
            new []{ "Food", "Create" },
            new []{ "Decor" },
            new []{ "Style", "Create" }
        };

        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<object> GetMoments()
        {
            var moments =
                from id in Enumerable.Range(1, 3)
                select new
                {
                    id,
                    title = $"Title {id}",
                    categories = _categories[id - 1],
                    postUrl = _moments[id - 1],
                    imageUrl = _momentImages[id - 1],
                    altText = $"alt text for image {id}"
                };

            return moments;
        }
    }
}

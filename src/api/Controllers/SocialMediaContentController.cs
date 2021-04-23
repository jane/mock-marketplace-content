using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mock_marketplace_content.Controllers
{
    [ApiController]
    [Route("api/content")]
    public class SocialMediaContentController : ControllerBase
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

        private static readonly string[] _instagramPosts =
        {
            "https://www.instagram.com/p/COAwOb_jBl-/",
            "https://www.instagram.com/p/CN_onfMjotu/",
            "https://www.instagram.com/p/CN_c9KBj4Qf/",
            "https://www.instagram.com/p/CN-4fmIBdAO/",
            "https://www.instagram.com/p/CN-jq-2juOi/",
            "https://www.instagram.com/p/CN-KK99Dt_5/",
            "https://www.instagram.com/p/CN96IYLt3SF/",
            "https://www.instagram.com/p/CN876P7D5my/",
            "https://www.instagram.com/p/CN8pU3HDl8k/",
            "https://www.instagram.com/p/CN8Bkl4DJDJ/",
            "https://www.instagram.com/p/CN7qAr_DDUa/",
            "https://www.instagram.com/p/CN6Xm7SDlhG/"
        };

        private static readonly string[] _instagramImages =
        {
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/p750x750/176597342_1534395136766914_617574059192526978_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=110&_nc_ohc=hn1eYGdAY-sAX-T8dHF&edm=AABBvjUAAAAA&ccb=7-4&oh=1510ba65041a42cb92265630c8aa3c26&oe=60A7785B&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176866995_3762236667221992_5389690706338900385_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=104&_nc_ohc=yaK28mYrpscAX8oe4o4&edm=AABBvjUAAAAA&ccb=7-4&oh=58e4951ad8f6904b67c473654d6e4bfd&oe=60A7AE78&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176177294_4070592936324912_5021445479123668111_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=100&_nc_ohc=yyQXz8Ej0goAX_MiacQ&edm=AABBvjUAAAAA&ccb=7-4&oh=3a5ce4ca28cad855f1cd2205ec238c09&oe=60AA1927&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/p750x750/176274050_162841755730012_5669440671813359407_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=104&_nc_ohc=NWw44W7KMy0AX8hJdNc&edm=AABBvjUAAAAA&ccb=7-4&oh=5d75422c139b1729b0a909ef98605d7e&oe=60A84555&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176270318_303620771144499_4666373706326365429_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=103&_nc_ohc=7ldevfrk6usAX8a9H2_&edm=AABBvjUAAAAA&ccb=7-4&oh=ddf3a3dfd797937f6b55554f784f50b3&oe=60A75634&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/177019766_315583533246469_1307417442345140258_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=101&_nc_ohc=A9Q9yBpWh5UAX84EO6u&edm=AABBvjUAAAAA&ccb=7-4&oh=50682957106b18a8a1176f59d7d880b9&oe=60A6A5B8&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176571990_188703053090180_2784915105311146109_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=108&_nc_ohc=KaTeKF8gfuoAX9BcrF4&edm=AABBvjUAAAAA&ccb=7-4&oh=76d3600473f205b2dd3a1a7f1874b076&oe=60A6E8E2&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176677513_778686809433817_3905394166709835052_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=101&_nc_ohc=yQEFYJKPQwMAX8K2UMh&edm=AABBvjUAAAAA&ccb=7-4&oh=1c751ae250878e51784c807b55c11188&oe=60A79AC6&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176143396_1036141343582306_7031198582377261760_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=102&_nc_ohc=ylGZcVACe7kAX_x4jJy&edm=AABBvjUAAAAA&ccb=7-4&oh=6b1196f6916c634077c35468200e5112&oe=60A8D228&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/176615774_865281230721716_4356961119880362700_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=108&_nc_ohc=VxAx_bYTU2YAX8Emikf&edm=AABBvjUAAAAA&ccb=7-4&oh=d332c5c890096b43cdf96f0e97ab7a60&oe=60A9AACB&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/p750x750/175964216_484081615968447_5136703945318138297_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=103&_nc_ohc=Oehk7rnCSPUAX-OopZz&edm=AABBvjUAAAAA&ccb=7-4&oh=8055cbca90eae03c400e88b1f162e757&oe=60A6F7A8&_nc_sid=83d603",
            "https://scontent-ort2-2.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s750x750/175997324_1803319909836474_8826179533366884121_n.jpg?tp=1&_nc_ht=scontent-ort2-2.cdninstagram.com&_nc_cat=106&_nc_ohc=aUGXR0W5qegAX9C7lJA&edm=AABBvjUAAAAA&ccb=7-4&oh=c99e7577c2238351048c471b45762cd2&oe=60A716C4&_nc_sid=83d603"
        };

        [HttpGet("moments")]
        [Produces("application/json")]
        public IEnumerable<object> GetMoments()
        {
            var moments =
                from id in Enumerable.Range(1, 3)
                select new
                {
                    id,
                    title = $"Title {id}",
                    categories = Enumerable.Range(1, id),
                    postUrl = _moments[id - 1],
                    imageUrl = _momentImages[id - 1],
                    altText = $"alt text for image {id}"
                };

            return moments;
        }

        [HttpGet("instagram")]
        [Produces("application/json")]
        public IEnumerable<object> GetInstagramPosts()
        {
            var posts =
                from id in Enumerable.Range(1, 12)
                select new
                {
                    id,
                    title = $"Title {id}",
                    postUrl = _instagramPosts[id - 1],
                    imageUrl = _instagramImages[id - 1],
                    altText = $"alt text for image {id}"
                };

            return posts;
        }
    }
}

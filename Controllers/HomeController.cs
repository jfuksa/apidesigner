using Microsoft.AspNetCore.Mvc;

namespace APIDesign.Controllers
{
    /// <summary>
    /// Komentar contolleru Home
    /// </summary>
    [ApiController]
    [Route("api/v1/home")]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Testovaci komentar metody
        /// </summary>
        /// <returns>Vraci stringovou hodnotu</returns>
        [HttpGet]
        public ActionResult<string> NazevMetodyJeJednoJakSeJmenujeMusiBytUnikatniVRamciTohotoControlleru()
        {
            return Ok("Hello world");
        }
    }
}
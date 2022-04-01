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
            return Ok("Hello world!");
        }
        
        /// <summary>
        /// Testovaci komentar metody
        /// </summary>
        /// <param name="message">Komentar parameteru metody</param>
        /// <returns>Vraci stringovou hodnotu</returns>
        [HttpGet("helloworld/{message}")]
        public ActionResult<string> DalsiNazevMetodyJeJednoJakSeJmenujeMusiBytUnikatniVRamciTohotoControlleru(string message)
        {
            return Ok(message);
        }
    }
}
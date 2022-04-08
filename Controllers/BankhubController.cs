using Microsoft.AspNetCore.Mvc;

namespace APIDesign.Controllers
{
    /// <summary>
    /// The API is used to obtain information about bank accounts and transactions.
    /// </summary>
    [ApiController]
    [Route("/bankhub-api/bankhub-api-v1")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class BankhubController : ControllerBase
    {
        /// <summary>
        /// Register a bank account in BankHub.
        /// </summary>
        /// <returns>Vraci stringovou hodnotu</returns>
        [HttpPut("register-account")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Reponse200successDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response400badRequestDTO))]
        public ActionResult RegisterAccount(RegisterAccountDTO registerAccountDto)
        {
            return Ok();
        }
    }

    /// <summary>
    /// Register a bank account in BankHub.
    /// </summary>
    public class RegisterAccountDTO
    {
        public string iban { get; set; }
    }

    public class Reponse200successDTO
    {
        public string code { get; set; }
        public string message { get; set; }
    }
    
    public class Response400badRequestDTO
    {
        public string code { get; set; }
        public string message { get; set; }
    }
}
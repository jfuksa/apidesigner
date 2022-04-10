using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace APIDesign.Controllers
{
    /// <summary>
    /// The API is used to obtain information about bank accounts and transactions.
    /// </summary>
    [ApiController]
    [Route("")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class BankHubController : ControllerBase
    {
        /// <summary>
        /// Register a bank account in BankHub.
        /// </summary>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Authorization required</response>
        /// <response code="409">Conflict</response>
        /// <response code="429">Client Error</response>
        /// <returns></returns>
        [HttpPut("register-account")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Reponse200SuccessDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response400BadRequestDTO))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(Response401AuthorizationRequiredDTO))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(Response409ConflictDTO))]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests, Type = typeof(Response429TooManyRequests))]
        public ActionResult RegisterAccount(RegisterAccountDTO registerAccountDto)
        {
            return Ok();
        }
        
        /// <summary>
        /// Unregister a bank account in BankHub.
        /// </summary>
        /// <returns></returns>
        [HttpPost("unregister-account")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Reponse200SuccessDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response400BadRequestDTO))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(Response401AuthorizationRequiredDTO))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(Response409ConflictDTO))]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests, Type = typeof(Response429TooManyRequests))]
        public ActionResult UnregisterAccount(UnregisterAccountDTO unregisterAccountDto)
        {
            return Ok();
        }
    }

    /// <summary>
    /// Register a bank account in BankHub.
    /// </summary>
    public class RegisterAccountDTO
    {
        /// <summary>
        /// International Bank Account Number of the account
        /// </summary>
        /// <example>HU23108000075000000015161027</example>
        [Required]
        public string iban { get; set; }
        
        /// <summary>
        ///  Business Identification Code of the account
        /// </summary>
        /// <example>TATRSKBXXXX</example>
        [Required]
        public string bic { get; set; }
        
        /// <summary>
        ///  Currency in which the account to be registered is held
        /// </summary>
        /// <example>CZK</example>
        [Required]
        public string currency { get; set; }
        
        /// <summary>
        ///  Internal account name. (Specified by the external system)
        /// </summary>
        /// <example>CZK_COD</example>
        public string name { get; set; }
        
        /// <summary>
        ///  Name of the bank providing the account
        /// </summary>
        /// <example>citi</example>
        public string providerName { get; set; }
        
        /// <summary>
        ///  Information on whether the account allows domestic payments
        /// </summary>
        /// <example>true/false</example>
        public string enabledDomesticPayment { get; set; }
        
        /// <summary>
        ///  Information on whether the account allows SEPA payments
        /// </summary>
        /// <example>true/false</example>
        public string enabledSepaPayment { get; set; }
        
        /// <summary>
        ///  Information on whether the account allows cross border payments
        /// </summary>
        /// <example>true/false</example>
        public string enabledCrossBorderPayment { get; set; }
    }

    /// <summary>
    /// Unregister a bank account in BankHub.
    /// </summary>
    public class UnregisterAccountDTO
    {
        /// <summary>
        /// International Bank Account Number of the account
        /// </summary>
        /// <example>HU23108000075000000015161027</example>
        [Required]
        public string iban { get; set; }
    }
        
    /// <summary>
    /// Success
    /// </summary>
    public class Reponse200SuccessDTO
    {
        [DefaultValue("200")]
        [Required]
        public string code { get; set; }
        [DefaultValue("OK")]
        [Required]
        public string message { get; set; }
    }
    
    /// <summary>
    /// Bad request
    /// </summary>
    public class Response400BadRequestDTO
    {
        [Required]
        public string code { get; set; }
        [Required]
        public string message { get; set; }
    }
    
    /// <summary>
    /// Authorization Required
    /// </summary>
    public class Response401AuthorizationRequiredDTO
    {
        [Required]
        public string code { get; set; }
        [Required]
        public string message { get; set; }
    }
    
    /// <summary>
    /// Conflict with another similar request
    /// </summary>
    public class Response409ConflictDTO
    {
        [Required]
        public string code { get; set; }
        [Required]
        public string message { get; set; }
    }
    
    /// <summary>
    /// Too Many Requests
    /// </summary>
    public class Response429TooManyRequests
    {
        [Required]
        public string code { get; set; }
        [Required]
        public string message { get; set; }
    }
}
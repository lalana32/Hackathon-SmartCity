using Microsoft.AspNetCore.Mvc;
using API.Services.Interfaces;
using API.DTOs;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController:ControllerBase
    {
      private readonly IEmailService _emailService;

      public EmailController(IEmailService emailService)
      {
        _emailService=emailService;
      }  
[HttpPost("send")]
public async Task<ActionResult> SendEmail([FromBody]EmailRequest request)
{
 if (request == null)
    {
        return BadRequest("Request is null");
    }

    try
    {
        await _emailService.SendEmailAsync(request.ToEmail, request.Subject, request.Message);
        return Ok("Email sent successfully.");
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"Internal server error: {ex.Message}");
    }
}

    }
}
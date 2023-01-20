using Microsoft.AspNetCore.Mvc;

namespace Backend_API.Controllers;

[ApiController]
[Route("[controller]")]
public class TagController : ControllerBase
{
    private static readonly string[] Tags =
    {
        "TrueAcc", "Acc", "TechAcc", "Dance", "Fitness", "Tech", "SpeedTech", "Balanced",
        "MidSpeed", "Speed", "HighSpeed", "Challenge", "Meme"
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Tags);
    }
}
using Backend_API.Interfaces;
using Backend_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_API.Controllers;

[ApiController]
[Route("[controller]")]
public class SectionController : ControllerBase
{
    private readonly ISectionService _sectionService;

    public SectionController(ISectionService sectionService)
    {
        _sectionService = sectionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetSection()
    {
        var section = await _sectionService.GetRandomSectionAsync();
        return Ok(section);
    }

    [HttpPost]
    public async Task<IActionResult> PostTags([FromBody] TagValuesResponse tagValues)
    {
        await _sectionService.AddTagValues(tagValues);
        return Ok();
    }
}
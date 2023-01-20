using Backend_API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;

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

    [HttpGet("/Sections")]
    public async Task<IActionResult> GetSections()
    {
        var sections = await _sectionService.GetAllSections();
        return Ok(sections);
    }

    [HttpPost]
    public async Task<IActionResult> PostTags([FromBody] TagValuesResponse tagValues)
    {
        await _sectionService.AddTagValues(tagValues);
        return Ok();
    }
}
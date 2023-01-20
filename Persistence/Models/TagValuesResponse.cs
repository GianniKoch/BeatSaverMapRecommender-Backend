namespace Persistence.Models;

public class TagValuesResponse
{
    public Guid Id { get; set; }
    public Section? Section { get; set; }
    public List<TagValue>? Tags { get; set; }
}
using Persistence.Interfaces;
using Persistence.Models;

namespace Persistence.Repositories;

public class InMemoryTagValueResponseRepository : ITagValueResponseRepository
{
    private readonly List<TagValuesResponse> _tagValuesResponses;

    public InMemoryTagValueResponseRepository()
    {
        _tagValuesResponses = new List<TagValuesResponse>();
    }

    public TagValuesResponse Save(TagValuesResponse section)
    {
        _tagValuesResponses.Add(section);
        return section;
    }

    public List<TagValuesResponse> ReadAll()
    {
        return _tagValuesResponses;
    }
}
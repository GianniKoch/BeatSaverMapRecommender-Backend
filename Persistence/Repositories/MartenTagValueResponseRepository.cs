using Marten;
using Persistence.Interfaces;
using Persistence.Models;

namespace Persistence.Repositories;

public class MartenTagValueResponseRepository : ITagValueResponseRepository
{
    private readonly IDocumentSession _session;

    public MartenTagValueResponseRepository(IDocumentSession session)
    {
        _session = session;
    }

    public async Task<TagValuesResponse> Save(TagValuesResponse section)
    {
        _session.Store(section);
        await _session.SaveChangesAsync();
        return section;
    }

    public async Task<IReadOnlyList<TagValuesResponse>> ReadAll()
    {
        var sections = await _session.Query<TagValuesResponse>().ToListAsync();
        return sections;
    }
}
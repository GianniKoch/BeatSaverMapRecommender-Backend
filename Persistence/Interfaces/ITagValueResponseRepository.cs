using Persistence.Models;

namespace Persistence.Interfaces;

public interface ITagValueResponseRepository
{
    Task<TagValuesResponse> Save(TagValuesResponse section);
    Task<IReadOnlyList<TagValuesResponse>> ReadAll();
}
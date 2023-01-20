using Persistence.Models;

namespace Persistence.Interfaces;

public interface ITagValueResponseRepository
{
    TagValuesResponse Save(TagValuesResponse section);
    List<TagValuesResponse> ReadAll();
}
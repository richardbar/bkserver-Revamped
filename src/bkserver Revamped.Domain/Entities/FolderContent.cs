using bkserver.Domain.Entities.Common;

namespace bkserver.Domain.Entities;

public class FolderContent
{
    public FolderContentId Id { get; init; }

    public IEnumerable<File> Files { get; init; }

    public IEnumerable<Folder> Folders { get; init; }
}

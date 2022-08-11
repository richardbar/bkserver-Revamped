using bkserver.Domain.Entities.Common;

namespace bkserver.Domain.Entities;

public class Folder
{
    public FolderId Id { get; init; }

    public FolderName Name { get; init; }

    public LastModified LastModified { get; init; }

    public Folder(DirectoryInfo directoryInfo)
    {
        ArgumentNullException.ThrowIfNull(directoryInfo);

        if (!directoryInfo.Exists)
            throw new ArgumentException("Directory does not exists", nameof(directoryInfo));

        Id = FolderId.From(Guid.NewGuid());
        Name = FolderName.From(directoryInfo.Name);
        LastModified = LastModified.From(directoryInfo.LastWriteTimeUtc);
    }

    public Folder(string directory)
    {
        ArgumentNullException.ThrowIfNull(directory);

        var directoryInfo = new DirectoryInfo(directory);
        if (!directoryInfo.Exists)
            throw new ArgumentException("Directory does not exists", nameof(directoryInfo));

        Id = FolderId.From(Guid.NewGuid());
        Name = FolderName.From(directoryInfo.Name);
        LastModified = LastModified.From(directoryInfo.LastWriteTimeUtc);
    }
}

using bkserver.Domain.Entities.Common;

namespace bkserver.Domain.Entities;

public class File
{
    public FileId Id { get; init; }

    public FileName Name { get; init; }

    public FileSize Size { get; init; }

    public LastModified LastModified { get; init; }

    public File(FileInfo fileInfo)
    {
        ArgumentNullException.ThrowIfNull(fileInfo);

        if (!fileInfo.Exists)
            throw new ArgumentException("File does not exists", nameof(fileInfo));

        Id = FileId.From(Guid.NewGuid());
        Name = FileName.From(fileInfo.Name);
        Size = FileSize.From(fileInfo.Length);
        LastModified = LastModified.From(fileInfo.LastWriteTimeUtc);
    }

    public File(string fileName)
    {
        ArgumentNullException.ThrowIfNull(fileName);

        var fileInfo = new FileInfo(fileName);
        if (!fileInfo.Exists)
            throw new ArgumentException("File does not exists", nameof(fileName));

        Id = FileId.From(Guid.NewGuid());
        Name = FileName.From(fileInfo.Name);
        Size = FileSize.From(fileInfo.Length);
        LastModified = LastModified.From(fileInfo.LastWriteTimeUtc);
    }
}
using ValueOf;

namespace bkserver.Domain.Entities.Common;

public sealed class FileId : ValueOf<Guid, FileId>
{
    protected override void Validate()
    {
        if (Value == Guid.Empty)
            throw new ArgumentException("File Id cannot be empty", nameof(FileId));
    }
}
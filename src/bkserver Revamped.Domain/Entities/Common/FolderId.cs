using ValueOf;

namespace bkserver.Domain.Entities.Common;

public sealed class FolderId : ValueOf<Guid, FolderId>
{
    protected override void Validate()
    {
        if (Value == Guid.Empty)
            throw new ArgumentException("Folder Id cannot be empty", nameof(FileId));
    }
}
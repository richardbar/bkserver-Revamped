using ValueOf;

namespace bkserver.Domain.Entities.Common;

public class FolderContentId : ValueOf<Guid, FolderContentId>
{
    protected override void Validate()
    {
        if (Value == Guid.Empty)
            throw new ArgumentException("Folder Content Id cannot be empty", nameof(FileId));
    }
}

using ValueOf;

namespace bkserver.Domain.Entities.Common;

public sealed class FileSize : ValueOf<long, FileSize>
{
    protected override void Validate()
    {
        if (Value < 0)
            throw new ArgumentException("File size cannot be negative", nameof(FileSize));
    }
}

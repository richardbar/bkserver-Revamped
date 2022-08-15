using Microsoft.AspNetCore.Mvc;

namespace bkserver.Domain.Contracts.Requests.Browse;

public sealed class DownloadFileRequest
{
    [FromQuery]
    public string Directory { get; init; } = default!;
}

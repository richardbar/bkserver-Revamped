using Microsoft.AspNetCore.Mvc;

namespace bkserver.Domain.Contracts.Requests.Browse;

public sealed class IndexRequest
{
    [FromQuery]
    public string Path { get; init; } = default!;
}
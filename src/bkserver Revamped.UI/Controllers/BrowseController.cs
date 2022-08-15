using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using bkserver.Domain.Contracts.Requests.Browse;
using bkserver.Domain.Extensions.System.IO;
using bkserver.Models;

namespace bkserver.Controllers;

public sealed class BrowseController : Controller
{
    private readonly ILogger<BrowseController> _logger;
    private readonly IConfiguration _configuration;

    private readonly string _baseDirectory;
    private readonly string _baseDirectoryInfo;

    public BrowseController(ILogger<BrowseController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;

        _baseDirectory = _configuration["BaseDirectory"];
    }

    public IActionResult Index(IndexRequest request)
    {
        var directoryInfo = new DirectoryInfo($"{_baseDirectory}{request.Path}");
        if (!directoryInfo.FullName.StartsWith(_baseDirectory))
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
        return View(directoryInfo.GetFolderContent());
    }
}

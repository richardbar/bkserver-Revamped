using bkserver.Domain.Entities.Common;

namespace bkserver.Domain.Extensions.bkserver.Domain.Entities.Common;

public static class FileSizeExtension
{
    private static string[] Sizes { get; } = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
    
    public static string GetHumanReadableFileSize(this FileSize fileSize)
    {
        double len = fileSize.Value;
        int order = 0;
        const int comparisonValue = (int)(1.01 * 1024);

        while (comparisonValue <= len)
        {
            order++;
            len /= 1024;
        }

        return String.Format("{0:0.##} {1}", len, Sizes[order]);
    }
}

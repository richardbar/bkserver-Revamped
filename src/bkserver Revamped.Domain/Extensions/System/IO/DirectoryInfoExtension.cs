using bkserver.Domain.Entities;

using File = bkserver.Domain.Entities.File;

namespace bkserver.Domain.Extensions.System.IO;

public static class DirectoryInfoExtension
{
    public static FolderContent GetFolderContent(this DirectoryInfo directoryInfo)
    {
        var filesList = new List<File>();
        var foldersList = new List<Folder>();

        FileInfo[] files = directoryInfo.GetFiles();
        DirectoryInfo[] directories = directoryInfo.GetDirectories();

        foreach (FileInfo file in files)
            filesList.Add(new File(file));
        
        foreach (DirectoryInfo directory in directories)
            foldersList.Add(new Folder(directory));

        var folderContent = new FolderContent()
        {
            Files = filesList,
            Folders = foldersList
        };

        return folderContent;
    }
}

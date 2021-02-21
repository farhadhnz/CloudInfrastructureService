using System.IO;

namespace CloudInfrastructureService.Provider
{
    public class ProviderBase 
    {
        protected void CheckCreateFolder(string path)
        {
            var folderExists = Directory.Exists(path);

            if (!folderExists)
                Directory.CreateDirectory(path);
        }
    }
}
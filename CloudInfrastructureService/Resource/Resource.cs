using System.IO;

namespace CloudInfrastructureService.Resource
{
    public class Resource : IResource
    {
        protected string name;

        public Resource(string name)
        {
            this.name = name;
        }

        public void Create(string infrastructurePath, ISubResource subResource)
        {
            // Create Resource Folder
            var resourcePath = $"{infrastructurePath}/{name}/";
            CheckCreateFolder(resourcePath);

            // Create Sub Resource 
            subResource.Create(resourcePath);
        }

        public void Delete(string resourcePath)
        {
            Directory.Delete(resourcePath, true);
        }

        protected void CheckCreateFolder(string path)
        {
            var resourceFolderExists = Directory.Exists(path);

            if (!resourceFolderExists)
                Directory.CreateDirectory(path);
            else
                throw new IOException("A resource with the same name exists in the infrastructure folder!");
        }

    }
}

using System.IO;

namespace CloudInfrastructureService.Resource
{
    public class Resource 
    {
        protected string name;

        public Resource(string name)
        {
            this.name = name;
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

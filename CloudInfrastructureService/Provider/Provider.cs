using CloudInfrastructureService.Resource;
using System.IO;

namespace CloudInfrastructureService.Provider
{
    public abstract class Provider : IProvider
    {
        public Provider()
        {
            providerName = GetProviderName();
        }

        private string providerName;
        public void CreateResource(string address, IResource resource, string infrastructureName, ISubResource subResource)
        {
            //// Get provider name
            //providerName = GetProviderName();

            // Check if provider folder exists and create if not
            var providerPath = $"{address}/{providerName}/";
            CheckCreateFolder(providerPath);

            // Check if infrastructure folder exists and create if not
            var infrastructurePath = $"{address}/{providerName}/{infrastructureName}";
            CheckCreateFolder(infrastructurePath);

            // Create Resource Instance
            resource.Create(infrastructurePath, subResource);
        }

        public void DeleteResource(string address, string resourceName, string infrastructureName)
        {
            // Check if provider folder exists
            var providerPath = $"{address}/{providerName}/";
            CheckFolder(providerPath);

            // Check if infrastructure folder exists
            var infrastructurePath = $"{address}/{providerName}/{infrastructureName}";
            CheckFolder(infrastructurePath);

            // Find resource Folder and Create resource Instance
            var resource = GetResourceByName(resourceName, infrastructurePath);
            var resourcePath = $"{infrastructurePath}/{resourceName}/";

            // Delete Resource Directory and Files
            resource.Delete(resourcePath);
        }

        public void CreateInfrastructure(string address, string infrastructureName)
        {
            // Check if provider folder exists and create if not
            var providerPath = $"{address}/{providerName}/";
            CheckCreateFolder(providerPath);

            // Check if infrastructure folder exists and create if not
            var infrastructurePath = $"{address}/{providerName}/{infrastructureName}";
            CheckCreateInfrastructureFolder(infrastructurePath);
        }

        public void DeleteInfrastructure(string address, string infrastructureName)
        {
            // Check if provider folder exists
            var providerPath = $"{address}/{providerName}/";
            CheckFolder(providerPath);

            // Check if infrastructure folder exists
            var infrastructurePath = $"{address}/{providerName}/{infrastructureName}";
            CheckFolder(infrastructurePath);

            // Delete the infrastructure folder
            Directory.Delete(infrastructurePath, true);
        }

        protected abstract string GetProviderName();
        private void CheckCreateFolder(string path)
        {
            var folderExists = Directory.Exists(path);

            if (!folderExists)
                Directory.CreateDirectory(path);
        }

        private void CheckFolder(string path)
        {
            var folderExists = Directory.Exists(path);

            if (!folderExists)
                throw new IOException($"The path {path} does not exist.");
        }

        private IResource GetResourceByName(string resourceName, string infrastructurePath)
        {
            var folderExists = Directory.Exists($"{infrastructurePath}/{resourceName}");

            if (!folderExists)
            {
                throw new IOException($"{resourceName} resource not found in the infrastructure!");
            }

            return new Resource.Resource(resourceName);
        }

        private void CheckCreateInfrastructureFolder(string infrastructurePath)
        {
            var infrastructureFolderExists = Directory.Exists(infrastructurePath);

            if (!infrastructureFolderExists)
                Directory.CreateDirectory(infrastructurePath);
            else
                throw new IOException("An infrastructure with the same name exists in the provider folder!");
        }
    }
}
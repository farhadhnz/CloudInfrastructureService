using CloudInfrastructureService.Resource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CloudInfrastructureService.Provider
{
    public class IgsProvider : ProviderBase, IProvider
    {
        public void CreateResource(string address, IResource resource, string infrastructureName, ISubResource subResource)
        {
            // Check if provider folder exists and create if not
            var providerPath = $"{address}/IGS/";
            CheckCreateFolder(providerPath);

            // Check if infrastructure folder exists and create if not
            var infrastructurePath = $"{address}/IGS/{infrastructureName}";
            CheckCreateFolder(infrastructurePath);

            // Create Resource Instance
            resource.Create(infrastructurePath, subResource);
        }
    }
}

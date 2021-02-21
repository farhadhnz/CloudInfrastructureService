using CloudInfrastructureService.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudInfrastructureService.Resource
{
    public class VMResource : Resource, IResource
    {

        public VMResource(string name) : base(name)
        {
        }

        public void Create(string infrastructurePath, ISubResource subResource)
        {
            // Create Resource Folder
            var resourcePath = $"{infrastructurePath}/name/";
            CheckCreateFolder(resourcePath);

            // Create Sub Resource 
            subResource.Create(resourcePath);
        }
    }
}

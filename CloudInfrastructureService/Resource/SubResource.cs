using System.IO;

namespace CloudInfrastructureService.Resource
{
    public abstract class SubResource : ISubResource
    {
        public void Create(string resourcePath)
        {
            //Get Content
            var content = CreateSubResourceContent();

            // Create resource file
            File.WriteAllText($"{resourcePath}/resource.json", content);
        }

        protected abstract string CreateSubResourceContent();
    }
}
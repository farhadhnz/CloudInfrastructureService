using CloudInfrastructureService.Resource;

namespace CloudInfrastructureService.Provider
{
    public interface IProvider
    {
        void CreateResource(string address, IResource resource, string infrastructure, ISubResource subResource);

        void DeleteResource(string address, string resourceName, string infrastructureName);
        void CreateInfrastructure(string address, string infrastructureName);
        void DeleteInfrastructure(string address, string infrastructureName);
    }
}

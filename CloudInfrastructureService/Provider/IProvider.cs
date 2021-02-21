using CloudInfrastructureService.Resource;

namespace CloudInfrastructureService.Provider
{
    public interface IProvider
    {
        void CreateResource(string address, IResource resource, string infrastructure, ISubResource subResource);
    }
}

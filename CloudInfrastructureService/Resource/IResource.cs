namespace CloudInfrastructureService.Resource
{
    public interface IResource
    {
        void Create(string infrastructurePath, ISubResource subResource);
    }
}
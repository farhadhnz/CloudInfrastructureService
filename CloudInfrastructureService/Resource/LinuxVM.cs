namespace CloudInfrastructureService.Resource
{
    public class LinuxVM : SubResource
    {
        protected override string CreateSubResourceContent()
        {
            return "{ type: LinuxVirtualMachine }";
        }
    }
}
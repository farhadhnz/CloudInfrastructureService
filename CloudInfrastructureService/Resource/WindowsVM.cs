namespace CloudInfrastructureService.Resource
{
    public class WindowsVM : SubResource
    {
        protected override string CreateSubResourceContent()
        {
            return "{ content: value}";
        }
    }
}
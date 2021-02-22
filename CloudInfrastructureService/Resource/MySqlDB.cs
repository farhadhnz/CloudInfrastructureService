namespace CloudInfrastructureService.Resource
{
    public class MySqlDB : SubResource
    {
        protected override string CreateSubResourceContent()
        {
            return "{ content: value}";
        }
    }
}
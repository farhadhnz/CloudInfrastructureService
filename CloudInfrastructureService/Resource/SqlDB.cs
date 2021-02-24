namespace CloudInfrastructureService.Resource
{
    public class SqlDB : SubResource
    {
        protected override string CreateSubResourceContent()
        {
            return "{ type: SQLDatabaseServer }";
        }
    }
}
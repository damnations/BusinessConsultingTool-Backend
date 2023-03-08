using Microsoft.Extensions.Configuration;

namespace BusinessConsultingTool_ASP.NET
{
    public class GetConnString
    {
        private IConfiguration _configuration;

        public GetConnString(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SomeMethod()
        {
            // retrieve App Service connection string
            var myConnString = _configuration.GetConnectionString("MONGODB_CONNECTION_STRING");
            return myConnString;
        }
    }
}

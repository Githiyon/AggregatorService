using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Constants
{
    public static class Constants
    {
        public const string ResponseMessage = "Saved Successfully...";
    }
    public static class JsDashobard
    {
        public static readonly List<string> RoleList = ["Admin", "User", "Anonyams"];
    }
    public static class Endpoint
    {
        public const string Url = "backendurl";
        public const string GetRegion = "Master/region";
        public const string ApiVersion = "ApiVersion";

        public static class JS
        {
            public const string ServerPath = "https://localhost:7178/api/";

            public static class JSController
            {
                public const string Default = "JS/";
                public const string GetDashboardCount = Default + "GetDashboardCounts";
            }
            public static class BlogController
            {
                public const string Default = "Blog/";
                public const string GetAllblogs = Default + "allblogs";
            }
        }
    }
}

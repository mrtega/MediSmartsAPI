using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediSmartsAPI.Routes
{
    public class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;
        public static class Registration
        {
            public const string GetAll = Base + "/user";

            public const string Get = Base + "/user/{userId}";

            public const string Update = Base + "/user/{userId}";

            public const string Delete = Base + "/user/{userId}";

            public const string Create = Base + "/user";
            //public const string Get = "api/v1/transaction{postId}";
        }
    }
}

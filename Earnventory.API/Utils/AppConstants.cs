using System.Collections.Generic;
using DevICGlobal.Utils;

namespace Earnventory.API.Utils
{
    public static class AppConstants
    {
        public static readonly List<string> AppDefaultRoles = new List<string>
        {
            "admin",
            "user",
            "super"
        };

        public const string MyAllowedSpecificOrigins = "_myAllowedSpecificOrigins";
        public const string LocalhostFrontEnd = "http://localhost:4200";
        public const string DevFrontEnd = "https://dev-ic-global-api-staging.herokuapp.com";

        public const string HttpMethodPost = "POST";
        public const string HttpMethodPut = "PUT";

        public static readonly List<string> AppDefaultPermissions = new List<string>
        {
            AppPermissions.CanAddUser,
            AppPermissions.CanAddRole
        };

        public const string AppDefaultAdminUser = "admin@admin.com";
        public const string AppDefaultAdminName = "admin";
    }
}
using System;

namespace DevICGlobal.Exceptions
{
    public class PermissionDeniedException : Exception
    {
        public PermissionDeniedException()
        {
            
        }

        public PermissionDeniedException(string permissionName) : base($"please request from the permission: '{permissionName}' from your admin")
        {
            
        }
    }
}
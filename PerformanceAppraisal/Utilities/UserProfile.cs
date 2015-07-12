using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.Security;

namespace PerformanceAppraisal.Utilities
{
    public class UserProfile: ProfileBase
    {
        public static UserProfile GetUserProfile(string userName)
        {
            return Create(userName) as UserProfile;
        }

        public static UserProfile GetUserProfile()
        {
            return Create(Membership.GetUser().UserName) as UserProfile;
        }

        [SettingsAllowAnonymous(false)]
        public string RolePriority
        {
            get { return base["RolePriority"] as string; }
            set { base["RolePriority"] = value; }
        }
    }
}
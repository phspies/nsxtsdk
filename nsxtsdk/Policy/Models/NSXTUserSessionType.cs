using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// User login session information
    /// </summary>
    [NSXTProperty(Description: @"User login session information")]
    public class NSXTUserSessionType 
    {
        /// <summary>
        /// Logout time if applicable.  An active user session has no logout time.
        /// </summary>
        [JsonProperty(PropertyName = "logout_time")]
        public long? LogoutTime { get; set; }
        /// <summary>
        /// Login time.
        /// </summary>
        [JsonProperty(PropertyName = "login_time", Required = Required.AllowNull)]
        public long LoginTime { get; set; }
        /// <summary>
        /// AD user name.
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        public string UserName { get; set; }
        /// <summary>
        /// AD Domain of user.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        public string DomainName { get; set; }
        /// <summary>
        /// User session ID. This also indicates whether this is VDI / RDSH.
        /// </summary>
        [JsonProperty(PropertyName = "user_session_id", Required = Required.AllowNull)]
        public int UserSessionId { get; set; }
    }
}

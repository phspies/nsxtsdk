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
    /// Identity Firewall user session data on a client machine (typically a VM).
        /// Multiple entries for the same user can be returned if the user logins to
        /// multiple sessions on the same VM.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall user session data on a client machine (typically a VM).Multiple entries for the same user can be returned if the user logins tomultiple sessions on the same VM.")]
    public class NSXTIdfwUserSessionDataType 
    {
        /// <summary>
        /// User session source can be one of:
        /// - GI (Guest Introspection)
        /// - ELS (AD Event log server)
        /// - LI (Log Insight)
        /// </summary>
        [JsonProperty(PropertyName = "session_source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdfwUserSessionDataSessionSourceEnumType? SessionSource { get; set; }
        /// <summary>
        /// AD user ID (may not exist).
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string? UserId { get; set; }
        /// <summary>
        /// User session ID.  This also indicates whether this is VDI / RDSH.
        /// </summary>
        [JsonProperty(PropertyName = "user_session_id", Required = Required.AllowNull)]
        public int UserSessionId { get; set; }
        /// <summary>
        /// Virtual machine (external ID or BIOS UUID) where login/logout events occurred.
        /// </summary>
        [JsonProperty(PropertyName = "vm_ext_id")]
        public string? VmExtId { get; set; }
        /// <summary>
        /// Identifier of user session data.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
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
        /// Logout time if applicable.  An active user session has no logout time.
        /// Non-active user session is stored (up to last 5 most recent entries) per
        /// VM and per user.
        /// </summary>
        [JsonProperty(PropertyName = "logout_time")]
        public long? LogoutTime { get; set; }
        /// <summary>
        /// AD Domain of user.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        public string DomainName { get; set; }
    }
}

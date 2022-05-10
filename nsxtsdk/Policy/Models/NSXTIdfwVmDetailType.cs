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
    /// Identity Firewall user login/session data for a single VM
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall user login/session data for a single VM")]
    public class NSXTIdfwVmDetailType 
    {
        /// <summary>
        /// Virtual machine (external ID or BIOS UUID) where login/logout event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "vm_ext_id", Required = Required.AllowNull)]
        public string VmExtId { get; set; }
        /// <summary>
        /// List of client machine IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "vm_ip_addresses")]
        public IList<string> VmIpAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "last_login_user_session")]
        public NSXTResourceReferenceType LastLoginUserSession { get; set; }
        /// <summary>
        /// List of user session data.
        /// </summary>
        [JsonProperty(PropertyName = "user_sessions", Required = Required.AllowNull)]
        public IList<NSXTIdfwUserSessionDataType> UserSessions { get; set; }
    }
}

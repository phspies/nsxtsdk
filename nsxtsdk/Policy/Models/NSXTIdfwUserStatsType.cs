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
    /// Identity Firewall user login/session data for a single user.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall user login/session data for a single user.")]
    public class NSXTIdfwUserStatsType 
    {
        /// <summary>
        /// AD user Identifier (String ID)
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string? UserId { get; set; }
        /// <summary>
        /// List of active (still logged in) user login/sessions data (no limit)
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions", Required = Required.AllowNull)]
        public IList<NSXTIdfwUserSessionDataType> ActiveSessions { get; set; }
        /// <summary>
        /// Optional list of up to 5 most recent archived (previously logged in) user
        /// login/session data.
        /// </summary>
        [JsonProperty(PropertyName = "archived_sessions")]
        public IList<NSXTIdfwUserSessionDataType> ArchivedSessions { get; set; }
    }
}

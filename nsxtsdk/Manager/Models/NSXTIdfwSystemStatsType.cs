using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Identity Firewall statistics data.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall statistics data.")]
    public class NSXTIdfwSystemStatsType 
    {
        /// <summary>
        /// Number of concurrent logged on users (across VDI & RDSH).  Multiple
        /// logins by the same user is counted as 1.
        /// </summary>
        [JsonProperty(PropertyName = "num_concurrent_users", Required = Required.AllowNull)]
        public int NumConcurrentUsers { get; set; }
        /// <summary>
        /// Number of active user sessions/logins in IDFW enabled compute collections
        /// (including both UP and DOWN hosts).  N sessions/logins by the same user
        /// is counted as n.
        /// </summary>
        [JsonProperty(PropertyName = "num_user_sessions", Required = Required.AllowNull)]
        public int NumUserSessions { get; set; }
    }
}

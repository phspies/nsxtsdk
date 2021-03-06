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
    /// Identity Firewall user login/session data for a single VM.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall user login/session data for a single VM.")]
    public class NSXTIdfwVmStatsType 
    {
        /// <summary>
        /// Virtual machine (external ID or BIOS UUID) where login/logout event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "vm_ext_id", Required = Required.AllowNull)]
        public string VmExtId { get; set; }
        /// <summary>
        /// List of active (still logged in) user login/sessions data (no limit)
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions", Required = Required.AllowNull)]
        public IList<NSXTIdfwUserSessionDataType> ActiveSessions { get; set; }
        /// <summary>
        /// Optional list of up to 5 most recent archived (previously logged in) user login/session data.
        /// </summary>
        [JsonProperty(PropertyName = "archived_sessions")]
        public IList<NSXTIdfwUserSessionDataType> ArchivedSessions { get; set; }
    }
}

// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Identity Firewall user login/session data for a single VM.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall user login/session data for a single VM.")]
    public class NSXTIdfwVmStatsType 
    {
        public NSXTIdfwVmStatsType()
        {
        }
        /// <summary>
        /// Virtual machine (external ID or BIOS UUID) where login/logout event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "vm_ext_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Virtual machine (external ID or BIOS UUID) where login/logout event occurred.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VmExtId { get; set; }
        /// <summary>
        /// List of active (still logged in) user login/sessions data (no limit)
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of active (still logged in) user login/sessions data (no limit)")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTIdfwUserSessionDataType> ActiveSessions { get; set; }
        /// <summary>
        /// Optional list of up to 5 most recent archived (previously logged in) user login/session data.
        /// </summary>
        [JsonProperty(PropertyName = "archived_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Optional list of up to 5 most recent archived (previously logged in) user login/session data.")]
        public IList<NSXTIdfwUserSessionDataType> ArchivedSessions { get; set; }
    }
}

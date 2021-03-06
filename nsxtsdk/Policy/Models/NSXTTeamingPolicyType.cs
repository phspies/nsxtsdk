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
    /// Uplink Teaming Policy
    /// </summary>
    [NSXTProperty(Description: @"Uplink Teaming Policy")]
    public class NSXTTeamingPolicyType 
    {
        /// <summary>
        /// Teaming policy
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTeamingPolicyPolicyEnumType Policy { get; set; }
        /// <summary>
        /// List of Uplinks used in standby list
        /// </summary>
        [JsonProperty(PropertyName = "standby_list")]
        public IList<NSXTUplinkType> StandbyList { get; set; }
        /// <summary>
        /// List of Uplinks used in active list
        /// </summary>
        [JsonProperty(PropertyName = "active_list", Required = Required.AllowNull)]
        public IList<NSXTUplinkType> ActiveList { get; set; }
        /// <summary>
        /// Flag for preemptive mode
        /// </summary>
        [JsonProperty(PropertyName = "rolling_order")]
        public bool? RollingOrder { get; set; }
    }
}

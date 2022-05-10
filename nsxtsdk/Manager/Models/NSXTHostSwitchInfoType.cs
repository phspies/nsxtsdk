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
    /// Information of host switch participating in transport zone
    /// </summary>
    [NSXTProperty(Description: @"Information of host switch participating in transport zone")]
    public class NSXTHostSwitchInfoType 
    {
        /// <summary>
        /// Type of a host switch
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostSwitchInfoHostSwitchTypeEnumType? HostSwitchType { get; set; }
        /// <summary>
        /// Unique ID of a host switch
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_id")]
        public string? HostSwitchId { get; set; }
        /// <summary>
        /// Mode of host switch
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostSwitchInfoHostSwitchModeEnumType? HostSwitchMode { get; set; }
        /// <summary>
        /// Name of a host switch
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name")]
        public string? HostSwitchName { get; set; }
    }
}

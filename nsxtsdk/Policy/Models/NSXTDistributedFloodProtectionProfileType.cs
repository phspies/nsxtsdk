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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDistributedFloodProtectionProfileType : NSXTFloodProtectionProfileType
    {
        /// <summary>
        /// If set to true, rst spoofing will be enabled. Flag is used only for distributed firewall profiles.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rst_spoofing")]
        public bool? EnableRstSpoofing { get; set; }
        /// <summary>
        /// If set to true, sync cache will be enabled. Flag is used only for distributed firewall profiles.
        /// </summary>
        [JsonProperty(PropertyName = "enable_syncache")]
        public bool? EnableSyncache { get; set; }
    }
}

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
    public class NSXTSegmentMonitoringProfileBindingMapType : NSXTMonitoringProfileBindingMapType
    {
        /// <summary>
        /// PolicyPath of associated IPFIX L2 Profile
        /// </summary>
        [JsonProperty(PropertyName = "ipfix_l2_profile_path")]
        public string? IpfixL2ProfilePath { get; set; }
        /// <summary>
        /// PolicyPath of associated Port Mirroring Profile
        /// </summary>
        [JsonProperty(PropertyName = "port_mirroring_profile_path")]
        public string? PortMirroringProfilePath { get; set; }
    }
}

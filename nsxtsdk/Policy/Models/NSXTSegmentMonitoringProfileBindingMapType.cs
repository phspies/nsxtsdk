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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSegmentMonitoringProfileBindingMapType : NSXTMonitoringProfileBindingMapType
    {
        /// <summary>
        /// PolicyPath of associated IPFIX L2 Profile
        /// </summary>
        [JsonProperty(PropertyName = "ipfix_l2_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"PolicyPath of associated IPFIX L2 Profile")]
        public string? IpfixL2ProfilePath { get; set; }
        /// <summary>
        /// PolicyPath of associated Port Mirroring Profile
        /// </summary>
        [JsonProperty(PropertyName = "port_mirroring_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"PolicyPath of associated Port Mirroring Profile")]
        public string? PortMirroringProfilePath { get; set; }
    }
}

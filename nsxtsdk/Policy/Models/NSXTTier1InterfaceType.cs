// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTier1InterfaceType : NSXTBaseTier0InterfaceType
    {
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        public NSXTTier1InterfaceUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// Maximum transmission unit (MTU) specifies the size of the largest
        /// packet that a network protocol can transmit.
        /// </summary>
        public int? Mtu { get; set; }
        /// <summary>
        /// This flag is used to enable/disable admin state on tier-1 service port.
        /// If admin_state flag value is not specified then default is UP. When set to UP
        /// then traffic on service port will be enabled and service port is enabled from
        /// routing perspective. When set to DOWN then traffic on service port will be
        /// disabled and service port is down from routing perspective. This flag is
        /// experimental because it will be used in V2T BYOT migration.
        /// </summary>
        public NSXTTier1InterfaceAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// Configrue IPv6 NDRA profile. Only one
        /// NDRA profile can be configured.
        /// </summary>
        public IList<string> Ipv6ProfilePaths { get; set; }
        /// <summary>
        /// Policy path of Segment to which interface is connected to.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path", Required = Required.AllowNull)]
        public string SegmentPath { get; set; }
    }
}

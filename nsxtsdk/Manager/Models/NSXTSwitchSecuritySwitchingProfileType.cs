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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSwitchSecuritySwitchingProfileType : NSXTBaseSwitchingProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTBpduFilterType BpduFilter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTRateLimitsType RateLimits { get; set; }
        /// <summary>
        /// RA Guard when enabled blocks unauthorized/rogue Router Advertisement (RA) packets.
        /// </summary>
        public bool? RaGuardEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTDhcpFilterType DhcpFilter { get; set; }
        /// <summary>
        /// A flag to block all traffic except IP/(G)ARP/BPDU
        /// </summary>
        public bool? BlockNonIpTraffic { get; set; }
    }
}

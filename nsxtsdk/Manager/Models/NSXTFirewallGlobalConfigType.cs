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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFirewallGlobalConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// This property is deprecated. The fast path mode is always enabled in Distributed Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "global_fastpath_mode_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"This property is deprecated. The fast path mode is always enabled in Distributed Firewall.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? GlobalFastpathModeEnabled { get; set; }
        /// <summary>
        /// When this flag is set to true, global address set is enabled in Distributed Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "global_addrset_mode_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"When this flag is set to true, global address set is enabled in Distributed Firewall.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? GlobalAddrsetModeEnabled { get; set; }
    }
}

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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFirewallGlobalConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// This property is deprecated. The fast path mode is always enabled in Distributed Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "global_fastpath_mode_enabled")]
        public bool? GlobalFastpathModeEnabled { get; set; }
        /// <summary>
        /// When this flag is set to true, global address set is enabled in Distributed Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "global_addrset_mode_enabled")]
        public bool? GlobalAddrsetModeEnabled { get; set; }
    }
}

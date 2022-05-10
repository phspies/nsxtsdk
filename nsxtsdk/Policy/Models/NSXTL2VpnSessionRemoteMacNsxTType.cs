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
    public class NSXTL2VpnSessionRemoteMacNsxTType : NSXTL2VpnSessionRemoteMacPerEPType
    {
        /// <summary>
        /// Display name of L2Vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// List of mac addresses of logical switches
        /// for an l2vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "remote_macs")]
        public IList<NSXTL2VpnSessionRemoteMacForSegmentType> RemoteMacs { get; set; }
    }
}

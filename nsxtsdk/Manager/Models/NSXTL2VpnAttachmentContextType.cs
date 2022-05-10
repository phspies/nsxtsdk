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
    public class NSXTL2VpnAttachmentContextType : NSXTAttachmentContextType
    {
        /// <summary>
        /// List of local egress IP addresses, used for
        /// local egress optimization.
        /// </summary>
        [JsonProperty(PropertyName = "local_egress_ip")]
        public IList<string> LocalEgressIp { get; set; }
        /// <summary>
        /// Tunnel Id to uniquely identify the extension.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_id", Required = Required.AllowNull)]
        public int TunnelId { get; set; }
    }
}

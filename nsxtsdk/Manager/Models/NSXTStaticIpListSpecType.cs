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
    public class NSXTStaticIpListSpecType : NSXTIpAssignmentSpecType
    {
        /// <summary>
        /// Subnet mask
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask", Required = Required.AllowNull)]
        public string SubnetMask { get; set; }
        /// <summary>
        /// List of IPs for transport node host switch virtual tunnel endpoints
        /// </summary>
        [JsonProperty(PropertyName = "ip_list", Required = Required.AllowNull)]
        public IList<string> IpList { get; set; }
        /// <summary>
        /// Gateway IP
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway", Required = Required.AllowNull)]
        public string DefaultGateway { get; set; }
    }
}

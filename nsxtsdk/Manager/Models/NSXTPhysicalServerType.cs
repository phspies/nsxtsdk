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
    public class NSXTPhysicalServerType : NSXTManagedResourceType
    {
        /// <summary>
        /// OS type of the physical server.
        /// </summary>
        [JsonProperty(PropertyName = "os_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPhysicalServerOsTypeEnumType? OsType { get; set; }
        /// <summary>
        /// IP addresses of the physical server specified by the admin while registering as Transport node in nsx.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
    }
}

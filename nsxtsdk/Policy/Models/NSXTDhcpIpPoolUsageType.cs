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
    public class NSXTDhcpIpPoolUsageType 
    {
        /// <summary>
        /// allocated percentage. COULD BE INACCURATE, REFERENCE ONLY.
        /// </summary>
        [JsonProperty(PropertyName = "allocated_percentage", Required = Required.AllowNull)]
        public long AllocatedPercentage { get; set; }
        /// <summary>
        /// pool size
        /// </summary>
        [JsonProperty(PropertyName = "pool_size", Required = Required.AllowNull)]
        public long PoolSize { get; set; }
        /// <summary>
        /// allocated number. COULD BE INACCURATE, REFERENCE ONLY.
        /// </summary>
        [JsonProperty(PropertyName = "allocated_number", Required = Required.AllowNull)]
        public long AllocatedNumber { get; set; }
        /// <summary>
        /// uuid of dhcp ip pool
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_ip_pool_id", Required = Required.AllowNull)]
        public string DhcpIpPoolId { get; set; }
    }
}

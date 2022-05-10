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
    public class NSXTIpAddressAllocationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Address that is allocated from pool
        /// </summary>
        [JsonProperty(PropertyName = "allocation_ip")]
        public string? AllocationIp { get; set; }
    }
}

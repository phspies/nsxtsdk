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
    public class NSXTIpAddressAllocationListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of IpAddressAllocations
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIpAddressAllocationType> Results { get; set; }
    }
}

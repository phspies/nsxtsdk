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
    public class NSXTAllocationIpAddressType : NSXTManagedResourceType
    {
        /// <summary>
        /// Address that is allocated from pool
        /// </summary>
        [JsonProperty(PropertyName = "allocation_id")]
        public string? AllocationId { get; set; }
    }
}

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
    public class NSXTAttachmentContextType 
    {
        /// <summary>
        /// A flag to indicate whether to allocate addresses from allocation
        /// pools bound to the parent logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "allocate_addresses")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAttachmentContextAllocateAddressesEnumType? AllocateAddresses { get; set; }
        /// <summary>
        /// Used to identify which concrete class it is
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
    }
}

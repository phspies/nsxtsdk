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
    public class NSXTIpfixConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of objects where the IPFIX Config will be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "applied_tos")]
        public IList<NSXTResourceReferenceType> AppliedTos { get; set; }
        /// <summary>
        /// Supported IPFIX Config Types.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpfixConfigResourceTypeEnumType ResourceType { get; set; }
    }
}

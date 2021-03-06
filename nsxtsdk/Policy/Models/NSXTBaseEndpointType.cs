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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("ServiceInstanceEndpoint", typeof(NSXTServiceInstanceEndpointType))]
    [JsonInheritanceAttribute("VirtualEndpoint", typeof(NSXTVirtualEndpointType))]
    [NSXTProperty(Description: @"")]
    public class NSXTBaseEndpointType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IPs where either inbound or outbound traffic is to be redirected.
        /// </summary>
        [JsonProperty(PropertyName = "target_ips", Required = Required.AllowNull)]
        public IList<NSXTIPInfoType> TargetIps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBaseEndpointResourceTypeEnumType ResourceType { get; set; }
    }
}

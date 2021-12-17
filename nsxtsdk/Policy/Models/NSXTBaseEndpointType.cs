// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        public NSXTBaseEndpointType()
        {
        }
        /// <summary>
        /// IPs where either inbound or outbound traffic is to be redirected.
        /// </summary>
        [JsonProperty(PropertyName = "target_ips", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IPs where either inbound or outbound traffic is to be redirected.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTIPInfoType> TargetIps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTBaseEndpointResourceTypeEnumType ResourceType { get; set; }
    }
}

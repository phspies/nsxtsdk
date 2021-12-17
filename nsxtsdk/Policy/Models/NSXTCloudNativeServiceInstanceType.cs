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
    [NSXTProperty(Description: @"")]
    public class NSXTCloudNativeServiceInstanceType : NSXTDiscoveredResourceType
    {
        public NSXTCloudNativeServiceInstanceType()
        {
        }
        /// <summary>
        /// Type of cloud native service.
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of cloud native service.")]
        public string? ServiceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTResourceReferenceType Source { get; set; }
        /// <summary>
        /// Id of service instance fetched from public cloud.
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of service instance fetched from public cloud.")]
        public string? ExternalId { get; set; }
    }
}

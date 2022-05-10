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
    public class NSXTCloudNativeServiceInstanceType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Type of cloud native service.
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        public string? ServiceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public NSXTResourceReferenceType Source { get; set; }
        /// <summary>
        /// Id of service instance fetched from public cloud.
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
    }
}

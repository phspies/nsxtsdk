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
    /// Advanced load balancer ClientLogStreamingFormat object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ClientLogStreamingFormat object")]
    public class NSXTALBClientLogStreamingFormatType 
    {
        /// <summary>
        /// List of log fields to be streamed, when selective fields
        /// (LOG_STREAMING_FORMAT_JSON_SELECTED) option is chosen.
        /// Only top-level fields in application or connection logs are
        /// supported.
        /// </summary>
        [JsonProperty(PropertyName = "included_fields")]
        public IList<string> IncludedFields { get; set; }
        /// <summary>
        /// Format for the streamed logs.
        /// Enum options - LOG_STREAMING_FORMAT_JSON_FULL,
        /// LOG_STREAMING_FORMAT_JSON_SELECTED.
        /// </summary>
        [JsonProperty(PropertyName = "format", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbclientLogStreamingFormatFormatEnumType Format { get; set; }
    }
}

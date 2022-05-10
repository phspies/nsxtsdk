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
    /// Advanced load balancer CompressionProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CompressionProfile object")]
    public class NSXTALBCompressionProfileType 
    {
        /// <summary>
        /// Custom filters used when auto compression is not selected.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public IList<NSXTALBCompressionFilterType> Filter { get; set; }
        /// <summary>
        /// Compress content automatically or add custom filters to
        /// define compressible content and compression levels.
        /// Enum options - AUTO_COMPRESSION, CUSTOM_COMPRESSION.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as AUTO_COMPRESSION.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbcompressionProfileTypeEnumType Type { get; set; }
        /// <summary>
        /// Compress only content types listed in this string group.
        /// Content types not present in this list are not compressed.
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "compressible_content_path")]
        public string? CompressibleContentPath { get; set; }
        /// <summary>
        /// Offload compression from the servers to AVI.
        /// Saves compute cycles on the servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "remove_accept_encoding_header", Required = Required.AllowNull)]
        public bool RemoveAcceptEncodingHeader { get; set; }
        /// <summary>
        /// Compress HTTP response content if it wasn't already
        /// compressed.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "compression", Required = Required.AllowNull)]
        public bool Compression { get; set; }
    }
}

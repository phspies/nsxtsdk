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
    public class NSXTIDSEventsBySignatureType : NSXTResourceType
    {
        /// <summary>
        /// Number of times this particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }
        /// <summary>
        /// First occurence of the intrusion, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "first_occurence")]
        public long? FirstOccurence { get; set; }
        /// <summary>
        /// Severity of the threat covered by the signature, can be Critical, High, Medium, or Low.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string? Severity { get; set; }
        /// <summary>
        /// Name of the signature pertaining to the detected intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "signature_name")]
        public string? SignatureName { get; set; }
        /// <summary>
        /// Flag indicating an ongoing intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "is_ongoing")]
        public bool? IsOngoing { get; set; }
        /// <summary>
        /// Signature ID pertaining to the detected intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id")]
        public long? SignatureId { get; set; }
        /// <summary>
        /// IDSEvent resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
    }
}

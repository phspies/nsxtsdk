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
    public class NSXTGlobalIdsSignatureType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// It denotes the global action of a IDS Signature.
        /// This will take precedence over IDS signature's action.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGlobalIdsSignatureActionEnumType? Action { get; set; }
        /// <summary>
        /// Represents the Signature's id.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id", Required = Required.AllowNull)]
        public string SignatureId { get; set; }
        /// <summary>
        /// Flag through which user can Enable/Disable a Signature at Global Level.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
    }
}

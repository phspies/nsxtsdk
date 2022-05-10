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
    /// Advanced load balancer URIParam object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer URIParam object")]
    public class NSXTALBURIParamType 
    {
        /// <summary>
        /// Token config either for the URI components or a constant
        /// string.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "tokens", Required = Required.AllowNull)]
        public IList<NSXTALBURIParamTokenType> Tokens { get; set; }
        /// <summary>
        /// URI param type.
        /// Enum options - URI_PARAM_TYPE_TOKENIZED.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlburiparamTypeEnumType Type { get; set; }
    }
}

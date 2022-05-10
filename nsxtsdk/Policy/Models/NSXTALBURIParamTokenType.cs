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
    /// Advanced load balancer URIParamToken object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer URIParamToken object")]
    public class NSXTALBURIParamTokenType 
    {
        /// <summary>
        /// Constant string to use as a token.
        /// </summary>
        [JsonProperty(PropertyName = "str_value")]
        public string? StrValue { get; set; }
        /// <summary>
        /// Token type for constructing the URI.
        /// Enum options - URI_TOKEN_TYPE_HOST, URI_TOKEN_TYPE_PATH,
        /// URI_TOKEN_TYPE_STRING, URI_TOKEN_TYPE_STRING_GROUP,
        /// URI_TOKEN_TYPE_REGEX.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlburiparamTokenTypeEnumType Type { get; set; }
        /// <summary>
        /// Index of the starting token in the incoming URI.
        /// </summary>
        [JsonProperty(PropertyName = "start_index")]
        public long? StartIndex { get; set; }
        /// <summary>
        /// Index of the ending token in the incoming URI.
        /// Allowed values are 0-65534.
        /// Special values are 65535 - 'end of string'.
        /// </summary>
        [JsonProperty(PropertyName = "end_index")]
        public long? EndIndex { get; set; }
    }
}

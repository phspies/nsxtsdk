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
    /// Advanced load balancer WafPSMMatchElement object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafPSMMatchElement object")]
    public class NSXTALBWafPSMMatchElementType 
    {
        /// <summary>
        /// The name of the request collection element.
        /// This can be empty, if we address the whole collection or a
        /// scalar element.
        /// </summary>
        [JsonProperty(PropertyName = "sub_element")]
        public string? SubElement { get; set; }
        /// <summary>
        /// Match_element index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// The variable specification.
        /// For example ARGS or REQUEST_COOKIES.
        /// This can be a scalar like PATH_INFO.
        /// Enum options - WAF_VARIABLE_ARGS, WAF_VARIABLE_ARGS_GET,
        /// WAF_VARIABLE_ARGS_POST, WAF_VARIABLE_ARGS_NAMES,
        /// WAF_VARIABLE_REQUEST_COOKIES, WAF_VARIABLE_QUERY_STRING,
        /// WAF_VARIABLE_REQUEST_BASENAME, WAF_VARIABLE_REQUEST_URI,
        /// WAF_VARIABLE_PATH_INFO.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPsmmatchElementNameEnumType Name { get; set; }
        /// <summary>
        /// Mark this element excluded, like in '!ARGS password'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "excluded")]
        public bool? Excluded { get; set; }
    }
}

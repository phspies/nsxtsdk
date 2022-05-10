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
    /// Advanced load balancer ReplaceStringVar object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ReplaceStringVar object")]
    public class NSXTALBReplaceStringVarType 
    {
        /// <summary>
        /// Type of replacement string - can be a variable exposed from
        /// datascript, value of an HTTP header or a custom user-input
        /// literal string.
        /// Enum options - DATASCRIPT_VAR, HTTP_HEADER_VAR,
        /// LITERAL_STRING.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbreplaceStringVarTypeEnumType? Type { get; set; }
        /// <summary>
        /// Value of the replacement string - name of variable exposed
        /// from datascript, name of the HTTP header or a custom
        /// user-input literal string.
        /// </summary>
        [JsonProperty(PropertyName = "val")]
        public string? Val { get; set; }
    }
}

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
    /// Advanced load balancer ReplaceStringVar object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ReplaceStringVar object")]
    public class NSXTALBReplaceStringVarType 
    {
        public NSXTALBReplaceStringVarType()
        {
        }
        /// <summary>
        /// Type of replacement string - can be a variable exposed from
        /// datascript, value of an HTTP header or a custom user-input
        /// literal string.
        /// Enum options - DATASCRIPT_VAR, HTTP_HEADER_VAR,
        /// LITERAL_STRING.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of replacement string - can be a variable exposed fromdatascript, value of an HTTP header or a custom user-inputliteral string.Enum options - DATASCRIPT_VAR, HTTP_HEADER_VAR,LITERAL_STRING.")]
        public NSXTAlbreplaceStringVarTypeEnumType? Type { get; set; }
        /// <summary>
        /// Value of the replacement string - name of variable exposed
        /// from datascript, name of the HTTP header or a custom
        /// user-input literal string.
        /// </summary>
        [JsonProperty(PropertyName = "val")]
        [NSXTProperty(IsRequired: false, Description: @"Value of the replacement string - name of variable exposedfrom datascript, name of the HTTP header or a customuser-input literal string.")]
        public string? Val { get; set; }
    }
}

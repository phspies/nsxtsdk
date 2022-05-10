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
    /// Advanced load balancer CustomParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CustomParams object")]
    public class NSXTALBCustomParamsType 
    {
        /// <summary>
        /// Placeholder for description of property is_dynamic of obj
        /// type CustomParams field type str  type boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_dynamic")]
        public bool? IsDynamic { get; set; }
        /// <summary>
        /// Placeholder for description of property is_sensitive of obj
        /// type CustomParams field type str  type boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_sensitive")]
        public bool? IsSensitive { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// value of CustomParams.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}

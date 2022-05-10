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
    /// Advanced load balancer RoleFilterMatchLabel object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer RoleFilterMatchLabel object")]
    public class NSXTALBRoleFilterMatchLabelType 
    {
        /// <summary>
        /// Values for filter match.
        /// Multiple values will be evaluated as OR.
        /// Example  key = value1 OR key = value2.
        /// Behavior for match is key = (STAR) if this field is empty.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }
        /// <summary>
        /// Key for filter match.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}

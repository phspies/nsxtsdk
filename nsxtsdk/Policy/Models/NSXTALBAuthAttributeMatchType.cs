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
    /// Advanced load balancer AuthAttributeMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthAttributeMatch object")]
    public class NSXTALBAuthAttributeMatchType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attribute_value_list", Required = Required.AllowNull)]
        public NSXTALBStringMatchType AttributeValueList { get; set; }
        /// <summary>
        /// Attribute name whose values will be looked up in the access
        /// lists.
        /// </summary>
        [JsonProperty(PropertyName = "attribute_name", Required = Required.AllowNull)]
        public string AttributeName { get; set; }
    }
}

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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBHttpRequestHeaderRewriteActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// Value of HTTP request header.
        /// </summary>
        [JsonProperty(PropertyName = "header_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of HTTP request header.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HeaderValue { get; set; }
        /// <summary>
        /// Name of HTTP request header.
        /// </summary>
        [JsonProperty(PropertyName = "header_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of HTTP request header.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HeaderName { get; set; }
    }
}

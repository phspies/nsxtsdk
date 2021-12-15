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
    public class NSXTLBHttpResponseHeaderRewriteActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// Value of header field
        /// </summary>
        [JsonProperty(PropertyName = "header_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of header field")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HeaderValue { get; set; }
        /// <summary>
        /// Name of a header field of HTTP request message.
        /// </summary>
        [JsonProperty(PropertyName = "header_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of a header field of HTTP request message.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HeaderName { get; set; }
    }
}

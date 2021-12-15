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
    public class NSXTLBHttpRedirectActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"HTTP response status code.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RedirectStatus { get; set; }
        /// <summary>
        /// The URL that the HTTP request is redirected to.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_url", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The URL that the HTTP request is redirected to.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RedirectUrl { get; set; }
    }
}
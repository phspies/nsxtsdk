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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBHttpRedirectActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_status", Required = Required.AllowNull)]
        public string RedirectStatus { get; set; }
        /// <summary>
        /// The URL that the HTTP request is redirected to.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_url", Required = Required.AllowNull)]
        public string RedirectUrl { get; set; }
    }
}

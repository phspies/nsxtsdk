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
    public class NSXTHttpPolicyLbMonitorProfileType : NSXTPolicyLbMonitorProfileType
    {
        /// <summary>
        /// For HTTP active healthchecks, the HTTP request url sent can be
        /// customized and can include query parameters.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        [NSXTProperty(IsRequired: false, Description: @"For HTTP active healthchecks, the HTTP request url sent can becustomized and can include query parameters.")]
        [NSXTDefaultProperty(Default: "/")]
        public string? Url { get; set; }
    }
}

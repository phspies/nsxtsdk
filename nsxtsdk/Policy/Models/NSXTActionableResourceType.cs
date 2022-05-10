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
    public class NSXTActionableResourceType : NSXTManagedResourceType
    {
        /// <summary>
        /// A resource reference on which actions can be performed
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}

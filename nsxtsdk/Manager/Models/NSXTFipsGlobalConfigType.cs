using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFipsGlobalConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// When this flag is set to true FIPS mode will be set on ssl encryptions of load balancer feature.
        /// </summary>
        [JsonProperty(PropertyName = "lb_fips_enabled")]
        public bool? LbFipsEnabled { get; set; }
    }
}

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
    /// Advanced load balancer HealthMonitorPop3 object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorPop3 object")]
    public class NSXTALBHealthMonitorPop3Type 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}

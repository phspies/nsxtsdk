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
    /// Advanced load balancer HealthMonitorPop3 object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorPop3 object")]
    public class NSXTALBHealthMonitorPop3Type 
    {
        public NSXTALBHealthMonitorPop3Type()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}
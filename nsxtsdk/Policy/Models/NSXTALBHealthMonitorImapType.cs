// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer HealthMonitorImap object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorImap object")]
    public class NSXTALBHealthMonitorImapType 
    {
        /// <summary>
        /// Folder to access.
        /// </summary>
        public string? Folder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}

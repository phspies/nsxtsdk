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
    /// Advanced load balancer DnsSrvRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsSrvRdata object")]
    public class NSXTALBDnsSrvRdataType 
    {
        /// <summary>
        /// Priority of the target hosting the service, low value
        /// implies higher priority for this service record.
        /// Allowed values are 0-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public long? Priority { get; set; }
        /// <summary>
        /// Service port.
        /// Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
        /// <summary>
        /// Relative weight for service records with same priority,
        /// high value implies higher preference for this service
        /// record.
        /// Allowed values are 0-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public long? Weight { get; set; }
        /// <summary>
        /// Canonical hostname, of the machine hosting the service,
        /// with no trailing period.
        /// 'default.host' is valid but not 'default.host.'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as default.host.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string? Target { get; set; }
    }
}

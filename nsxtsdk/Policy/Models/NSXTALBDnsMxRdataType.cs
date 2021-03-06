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
    /// Advanced load balancer DnsMxRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsMxRdata object")]
    public class NSXTALBDnsMxRdataType 
    {
        /// <summary>
        /// The priority field identifies which mail server should be
        /// preferred.
        /// Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        public long Priority { get; set; }
        /// <summary>
        /// Fully qualified domain name of a mailserver.
        /// The host name maps directly to one or more address records
        /// in the DNS table, and must not point to any CNAME records
        /// (RFC 2181).
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
    }
}

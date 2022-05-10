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
    /// Advanced load balancer ClientLogFilter object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ClientLogFilter object")]
    public class NSXTALBClientLogFilterType 
    {
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Special values are 0 - 'infinite'.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }
        /// <summary>
        /// Placeholder for description of property all_headers of obj
        /// type ClientLogFilter field type str  type boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// Placeholder for description of property enabled of obj type
        /// ClientLogFilter field type str  type boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public NSXTALBStringMatchType Uri { get; set; }
    }
}

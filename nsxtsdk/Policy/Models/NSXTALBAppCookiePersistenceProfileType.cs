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
    /// Advanced load balancer AppCookiePersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AppCookiePersistenceProfile object")]
    public class NSXTALBAppCookiePersistenceProfileType 
    {
        /// <summary>
        /// Header or cookie name for application cookie persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name", Required = Required.AllowNull)]
        public string PrstHdrName { get; set; }
        /// <summary>
        /// Key to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key")]
        public string? EncryptionKey { get; set; }
        /// <summary>
        /// The length of time after a client's connections have closed
        /// before expiring the client's persistence to a server.
        /// Allowed values are 1-720.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 20.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
    }
}

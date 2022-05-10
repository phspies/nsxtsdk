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
    /// APH information.
    /// </summary>
    [NSXTProperty(Description: @"APH information.")]
    public class NSXTAphInfoType 
    {
        /// <summary>
        /// Port of APH service
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
        /// <summary>
        /// Node ID of the APH service
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        public string NodeId { get; set; }
        /// <summary>
        /// whether or not fqdn flag is on
        /// </summary>
        [JsonProperty(PropertyName = "use_fqdn")]
        public bool? UseFqdn { get; set; }
        /// <summary>
        /// PEM Certificate of APH service
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        public string Certificate { get; set; }
        /// <summary>
        /// IP address of APH service
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// FQDN, only returned by GET /sites and GET /sites/self
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// ID of the APH service
        /// </summary>
        [JsonProperty(PropertyName = "uuid", Required = Required.AllowNull)]
        public string Uuid { get; set; }
    }
}

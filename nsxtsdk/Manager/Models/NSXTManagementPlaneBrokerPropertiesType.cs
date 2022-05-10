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
    /// Information about a management plane node this controller is configured to communicate with
    /// </summary>
    [NSXTProperty(Description: @"Information about a management plane node this controller is configured to communicate with")]
    public class NSXTManagementPlaneBrokerPropertiesType 
    {
        /// <summary>
        /// IP address or hostname of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Port number of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Certificate thumbprint of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        public string Thumbprint { get; set; }
    }
}

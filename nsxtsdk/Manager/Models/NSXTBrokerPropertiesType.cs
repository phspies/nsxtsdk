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
    /// Information about a management plane node this transport node is configured to communicate with
    /// </summary>
    [NSXTProperty(Description: @"Information about a management plane node this transport node is configured to communicate with")]
    public class NSXTBrokerPropertiesType 
    {
        /// <summary>
        /// Indicates whether this broker is the master.
        /// </summary>
        [JsonProperty(PropertyName = "BrokerIsMaster")]
        public string? BrokerIsMaster { get; set; }
        /// <summary>
        /// IP address or hostname of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "BrokerIpAddress", Required = Required.AllowNull)]
        public string BrokerIpAddress { get; set; }
        /// <summary>
        /// Type of host running the broker.
        /// </summary>
        [JsonProperty(PropertyName = "BrokerVirtualHost")]
        public string? BrokerVirtualHost { get; set; }
        /// <summary>
        /// Certificate thumbprint of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "BrokerSslCertThumbprint", Required = Required.AllowNull)]
        public string BrokerSslCertThumbprint { get; set; }
        /// <summary>
        /// Port number of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "BrokerPort")]
        public string? BrokerPort { get; set; }
        /// <summary>
        /// Fully qualified domain name of the message bus broker on the management plane node.
        /// </summary>
        [JsonProperty(PropertyName = "BrokerFqdn")]
        public string? BrokerFqdn { get; set; }
    }
}

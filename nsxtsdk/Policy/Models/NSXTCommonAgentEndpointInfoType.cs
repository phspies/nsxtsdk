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
    /// An endpoint to connect to Kafka/ingress of the NSX Application Platform.
        /// Either FQDN or IP address can be used in the endpoint info.
    /// </summary>
    [NSXTProperty(Description: @"An endpoint to connect to Kafka/ingress of the NSX Application Platform.Either FQDN or IP address can be used in the endpoint info.")]
    public class NSXTCommonAgentEndpointInfoType 
    {
        /// <summary>
        /// The port number where the broker is listening to.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// The IP address or the full qualified domain name of Kafka broker/ingress.
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
    }
}

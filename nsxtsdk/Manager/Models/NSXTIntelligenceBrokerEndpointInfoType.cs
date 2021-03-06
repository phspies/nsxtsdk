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
    /// This is deprecated. Please use CommonAgentEndpointInfo instead.
        /// An endpoint to connect to NSX-Intelligence broker.
        /// Either FQDN or IP address can be used in the endpoint info.
    /// </summary>
    [NSXTProperty(Description: @"This is deprecated. Please use CommonAgentEndpointInfo instead.An endpoint to connect to NSX-Intelligence broker.Either FQDN or IP address can be used in the endpoint info.")]
    public class NSXTIntelligenceBrokerEndpointInfoType 
    {
        /// <summary>
        /// The port number where the broker is listening to.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
        /// <summary>
        /// The IP address or the full qualified domain name of broker.
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
    }
}

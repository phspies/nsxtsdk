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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMPAConfigPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// The nodes client type.
        /// </summary>
        [JsonProperty(PropertyName = "RmqClientType")]
        public object RmqClientType { get; set; }
        /// <summary>
        /// The list of messaging brokers this controller is configured with.
        /// </summary>
        [JsonProperty(PropertyName = "RmqBrokerCluster")]
        public IList<NSXTBrokerPropertiesType> RmqBrokerCluster { get; set; }
        /// <summary>
        /// The shared secret to use when autnenticating to the management plane's message bus. Not returned in REST responses.
        /// </summary>
        [JsonProperty(PropertyName = "SharedSecret")]
        public string? SharedSecret { get; set; }
        /// <summary>
        /// The account name to use when authenticating to the management plane's message bus.
        /// </summary>
        [JsonProperty(PropertyName = "AccountName")]
        public object AccountName { get; set; }
    }
}

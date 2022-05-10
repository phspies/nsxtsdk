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
    /// Information about a messaging client
    /// </summary>
    [NSXTProperty(Description: @"Information about a messaging client")]
    public class NSXTMsgClientInfoType 
    {
        /// <summary>
        /// Software version of the node.
        /// </summary>
        [JsonProperty(PropertyName = "software_version")]
        public string? SoftwareVersion { get; set; }
        /// <summary>
        /// Account name for the messaging client. Identifies the client on the management plane message bus.
        /// </summary>
        [JsonProperty(PropertyName = "account_name")]
        public string? AccountName { get; set; }
        /// <summary>
        /// Messaging client's certificate. Used to authenticate to the control plane messaging endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
        /// <summary>
        /// Messaging client's secret. Used to authenticate to the management plane messaging broker.
        /// </summary>
        [JsonProperty(PropertyName = "shared_secret")]
        public string? SharedSecret { get; set; }
    }
}

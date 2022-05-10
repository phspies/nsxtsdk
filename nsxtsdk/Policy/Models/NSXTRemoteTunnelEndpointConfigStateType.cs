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
    /// Remote tunnel endpoint configuration state
    /// </summary>
    [NSXTProperty(Description: @"Remote tunnel endpoint configuration state")]
    public class NSXTRemoteTunnelEndpointConfigStateType 
    {
        /// <summary>
        /// List of remote tunnel endpoints which are configured on this node
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<NSXTRemoteTunnelEndpointType> Endpoints { get; set; }
    }
}

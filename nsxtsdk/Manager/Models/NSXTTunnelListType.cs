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
    public class NSXTTunnelListType : NSXTListResultType
    {
        /// <summary>
        /// List of transport node tunnels
        /// </summary>
        [JsonProperty(PropertyName = "tunnels")]
        public IList<NSXTTunnelPropertiesType> Tunnels { get; set; }
    }
}

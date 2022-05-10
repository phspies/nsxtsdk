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
    public class NSXTStubStatusType 
    {
        /// <summary>
        /// Is stub up
        /// </summary>
        [JsonProperty(PropertyName = "connection_up", Required = Required.AllowNull)]
        public bool ConnectionUp { get; set; }
        /// <summary>
        /// IP/FQDN of the node
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
    }
}

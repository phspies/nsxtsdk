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
    public class NSXTMgmtConnStatusType 
    {
        /// <summary>
        /// Indicates the controller node's MP channel connectivity status
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMgmtConnStatusConnectivityStatusEnumType? ConnectivityStatus { get; set; }
    }
}

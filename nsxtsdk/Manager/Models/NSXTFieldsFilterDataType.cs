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
    public class NSXTFieldsFilterDataType : NSXTLiveTraceFilterDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_info")]
        public NSXTIPInfoType IpInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_info")]
        public NSXTTransportInfoType TransportInfo { get; set; }
    }
}

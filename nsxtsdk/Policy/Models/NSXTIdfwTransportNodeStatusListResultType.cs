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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIdfwTransportNodeStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of transport node ids and  status for idfw enabled
        /// Compute collection.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTIdfwTransportNodeStatusType> Results { get; set; }
    }
}

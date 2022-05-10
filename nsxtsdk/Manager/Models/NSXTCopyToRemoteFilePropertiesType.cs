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
    public class NSXTCopyToRemoteFilePropertiesType : NSXTCopyRemoteFilePropertiesType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        public NSXTProtocolType Protocol { get; set; }
    }
}

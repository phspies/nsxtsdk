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
    public class NSXTIpfixCollectorConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// IPFIX Collectors
        /// </summary>
        [JsonProperty(PropertyName = "collectors", Required = Required.AllowNull)]
        public IList<NSXTIpfixCollectorType> Collectors { get; set; }
    }
}

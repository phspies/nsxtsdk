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
    public class NSXTEtherTypeServiceEntryType : NSXTServiceEntryType
    {
        /// <summary>
        /// Type of the encapsulated protocol
        /// </summary>
        [JsonProperty(PropertyName = "ether_type", Required = Required.AllowNull)]
        public long EtherType { get; set; }
    }
}

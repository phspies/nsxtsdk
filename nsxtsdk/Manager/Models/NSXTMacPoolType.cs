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
    public class NSXTMacPoolType : NSXTManagedResourceType
    {
        /// <summary>
        /// Array of ranges for MAC addresses
        /// </summary>
        [JsonProperty(PropertyName = "ranges", Required = Required.AllowNull)]
        public IList<NSXTMacRangeType> Ranges { get; set; }
    }
}

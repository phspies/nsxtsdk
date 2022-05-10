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
    public class NSXTPrefixListType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Specify ordered list of network prefixes.
        /// </summary>
        [JsonProperty(PropertyName = "prefixes", Required = Required.AllowNull)]
        public IList<NSXTPrefixEntryType> Prefixes { get; set; }
    }
}

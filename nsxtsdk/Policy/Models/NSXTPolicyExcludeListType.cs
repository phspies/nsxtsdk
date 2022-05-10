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
    public class NSXTPolicyExcludeListType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of the members in the exclude list
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        public IList<string> Members { get; set; }
    }
}

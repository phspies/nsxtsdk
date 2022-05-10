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
    public class NSXTPrincipalType 
    {
        /// <summary>
        /// Attribute list.
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Required = Required.AllowNull)]
        public IList<NSXTKeyValueType> Attributes { get; set; }
    }
}

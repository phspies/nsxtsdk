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
    public class NSXTPolicyLabelType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy entity paths referred by the label instance
        /// </summary>
        [JsonProperty(PropertyName = "refs")]
        public IList<string> Refs { get; set; }
        /// <summary>
        /// Policy intent entity type from PolicyResourceType
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
    }
}

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
    public class NSXTSshKeyPropertiesType : NSXTSshKeyBasePropertiesType
    {
        /// <summary>
        /// SSH key type
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// SSH key value
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
    }
}

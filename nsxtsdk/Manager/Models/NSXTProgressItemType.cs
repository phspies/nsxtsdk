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
    public class NSXTProgressItemType 
    {
        /// <summary>
        /// Finer details, usually there is only one part
        /// </summary>
        [JsonProperty(PropertyName = "parts")]
        public IList<NSXTProgressItemPartType> Parts { get; set; }
        /// <summary>
        /// Name of the item
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
    }
}

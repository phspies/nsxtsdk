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
    public class NSXTStorageClassesType : NSXTListResultType
    {
        /// <summary>
        /// List the name of storage classes
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public IList<string> Name { get; set; }
    }
}

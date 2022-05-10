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
    public class NSXTNestedServiceServiceEntryType : NSXTServiceEntryType
    {
        /// <summary>
        /// path of nested service
        /// </summary>
        [JsonProperty(PropertyName = "nested_service_path", Required = Required.AllowNull)]
        public string NestedServicePath { get; set; }
    }
}

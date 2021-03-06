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
    public class NSXTEsxGlobalOpaqueConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// A list of global opaque configuration for ESX hosts.
        /// </summary>
        [JsonProperty(PropertyName = "opaque_config", Required = Required.AllowNull)]
        public IList<NSXTKeyValuePairType> OpaqueConfig { get; set; }
    }
}

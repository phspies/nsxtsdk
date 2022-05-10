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
    public class NSXTPatchResourcesType : NSXTActionType
    {
        /// <summary>
        /// Injections holding keys (variables) and their corresponding values.
        /// </summary>
        [JsonProperty(PropertyName = "injections")]
        public IList<NSXTInjectionType> Injections { get; set; }
        /// <summary>
        /// Patch body representing a Hierarchical Patch payload. The resources included in the body
        /// are patched replacing the injections' keys with their actual values.
        /// </summary>
        [JsonProperty(PropertyName = "body", Required = Required.AllowNull)]
        public object Body { get; set; }
    }
}

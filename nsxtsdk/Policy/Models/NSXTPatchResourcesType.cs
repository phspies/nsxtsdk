// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPatchResourcesType : NSXTActionType
    {
        public NSXTPatchResourcesType()
        {
        }
        /// <summary>
        /// Injections holding keys (variables) and their corresponding values.
        /// </summary>
        [JsonProperty(PropertyName = "injections")]
        [NSXTProperty(IsRequired: false, Description: @"Injections holding keys (variables) and their corresponding values.")]
        public IList<NSXTInjectionType> Injections { get; set; }
        /// <summary>
        /// Patch body representing a Hierarchical Patch payload. The resources included in the body
        /// are patched replacing the injections' keys with their actual values.
        /// </summary>
        [JsonProperty(PropertyName = "body", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Patch body representing a Hierarchical Patch payload. The resources included in the bodyare patched replacing the injections&apos; keys with their actual values.")]
        [System.ComponentModel.DataAnnotations.Required]
        public object Body { get; set; }
    }
}

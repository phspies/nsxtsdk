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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTContainerIngressPolicyListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of Container Ingress Policy specs
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of Container Ingress Policy specs")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTContainerIngressPolicyType> Results { get; set; }
    }
}

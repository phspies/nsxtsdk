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
    /// It represents the resource information which could identify resource.
    /// </summary>
    [NSXTProperty(Description: @"It represents the resource information which could identify resource.")]
    public class NSXTResourceInfoType 
    {
        /// <summary>
        /// It will represent resource identifiers. For example, policy objects will be
        /// represented with paths and virtual machine will be represented with external
        /// ids.
        /// </summary>
        [JsonProperty(PropertyName = "resource_ids", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"It will represent resource identifiers. For example, policy objects will berepresented with paths and virtual machine will be represented with externalids.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> ResourceIds { get; set; }
        /// <summary>
        /// It will represent resource type on which tag bulk operation to be performed.
        /// Supported resource type is VirtualMachine.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"It will represent resource type on which tag bulk operation to be performed.Supported resource type is VirtualMachine.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResourceType { get; set; }
    }
}

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
        public IList<string> ResourceIds { get; set; }
        /// <summary>
        /// It will represent resource type on which tag bulk operation to be performed.
        /// Supported resource type is VirtualMachine.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
    }
}

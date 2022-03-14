// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAdvanceClusterRestoreInputType 
    {
        /// <summary>
        /// Unique id of an instruction (as returned by the GET /restore/status
        /// call) for which input is to be provided
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// List of resources for which the instruction is applicable.
        /// </summary>
        [JsonProperty(PropertyName = "resources", Required = Required.AllowNull)]
        public IList<NSXTSelectableResourceReferenceType> Resources { get; set; }
    }
}

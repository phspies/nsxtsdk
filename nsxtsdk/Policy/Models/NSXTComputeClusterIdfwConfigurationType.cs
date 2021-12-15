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
    public class NSXTComputeClusterIdfwConfigurationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Contains actual policy resource reference object
        /// </summary>
        [JsonProperty(PropertyName = "member", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains actual policy resource reference object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPolicyResourceReferenceType Member { get; set; }
        /// <summary>
        /// If set to true, idfw is enabled for this cluster
        /// </summary>
        [JsonProperty(PropertyName = "cluster_idfw_enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"If set to true, idfw is enabled for this cluster")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool ClusterIdfwEnabled { get; set; }
    }
}
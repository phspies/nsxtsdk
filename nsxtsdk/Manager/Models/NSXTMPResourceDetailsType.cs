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
    /// Contains manager and policy resource id.
    /// </summary>
    [NSXTProperty(Description: @"Contains manager and policy resource id.")]
    public class NSXTMPResourceDetailsType 
    {
        /// <summary>
        /// Policy resource path.
        /// </summary>
        [JsonProperty(PropertyName = "policy_path")]
        public string? PolicyPath { get; set; }
        /// <summary>
        /// Manager resource id.
        /// </summary>
        [JsonProperty(PropertyName = "manager_id", Required = Required.AllowNull)]
        public string ManagerId { get; set; }
        /// <summary>
        /// Principle Identity to be used for MP to Policy promotion in GENERIC workflow.This is internal only.
        /// </summary>
        [JsonProperty(PropertyName = "principle_identity")]
        public string? PrincipleIdentity { get; set; }
        /// <summary>
        /// Whether to skip/override the resource in case of multiple resource migration . By default. it will be skip.
        /// </summary>
        [JsonProperty(PropertyName = "override")]
        public bool? Override { get; set; }
        /// <summary>
        /// Policy resource id.
        /// </summary>
        [JsonProperty(PropertyName = "policy_id")]
        public string? PolicyId { get; set; }
        /// <summary>
        /// Linked resources.
        /// </summary>
        [JsonProperty(PropertyName = "linked_ids")]
        public IList<NSXTMPResourceLinkedDetailsType> LinkedIds { get; set; }
        /// <summary>
        /// Resource metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTMPResourceMetadataType> Metadata { get; set; }
    }
}

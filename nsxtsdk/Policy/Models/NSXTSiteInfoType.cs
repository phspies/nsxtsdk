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
    /// Information related to Sites applicable for given VHC.
    /// </summary>
    [NSXTProperty(Description: @"Information related to Sites applicable for given VHC.")]
    public class NSXTSiteInfoType 
    {
        /// <summary>
        /// For the local manager this needs to be set to 'default'.
        /// This represents the path of the site which is managed by Global Manager.
        /// </summary>
        [JsonProperty(PropertyName = "site_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"For the local manager this needs to be set to &apos;default&apos;.This represents the path of the site which is managed by Global Manager.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SitePath { get; set; }
        /// <summary>
        /// The transport zone has to be set when creating VHC on Local manager.
        /// If not set for local manager, default transport zone will be used.
        /// For the Global Manager the transport zone path will be picked up from the site.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_paths")]
        [NSXTProperty(IsRequired: false, Description: @"The transport zone has to be set when creating VHC on Local manager.If not set for local manager, default transport zone will be used.For the Global Manager the transport zone path will be picked up from the site.")]
        public IList<string> TransportZonePaths { get; set; }
        /// <summary>
        /// The edge cluster on which the networking elements for the VHC will be created.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_paths", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The edge cluster on which the networking elements for the VHC will be created.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> EdgeClusterPaths { get; set; }
    }
}

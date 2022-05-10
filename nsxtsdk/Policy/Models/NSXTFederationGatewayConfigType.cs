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
    public class NSXTFederationGatewayConfigType : NSXTFederationConnectivityConfigType
    {
        /// <summary>
        /// Indicies for cross site allocation for edge cluster
        /// and its members referred by gateway.
        /// </summary>
        [JsonProperty(PropertyName = "site_allocation_indices")]
        public IList<NSXTSiteAllocationIndexForEdgeType> SiteAllocationIndices { get; set; }
        /// <summary>
        /// Global UUID for transit segment id to be used by Layer2 services for
        /// federation usecases.
        /// </summary>
        [JsonProperty(PropertyName = "transit_segment_id")]
        public string? TransitSegmentId { get; set; }
    }
}

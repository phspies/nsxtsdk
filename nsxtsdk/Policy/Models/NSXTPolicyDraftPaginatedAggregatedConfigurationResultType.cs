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
    /// Paginated result of aggregated configuration of a policy draft
    /// </summary>
    [NSXTProperty(Description: @"Paginated result of aggregated configuration of a policy draft")]
    public class NSXTPolicyDraftPaginatedAggregatedConfigurationResultType 
    {
        /// <summary>
        /// Paginated aggregated configuration of a given draft.
        /// For an initial API call, if request_id is present in response, then this is
        /// a paginated aggregated configuration of a given draft. To get more granular
        /// aggregated configuration, request_id need to be passed to subsequent API
        /// calls.
        /// Absence of request_id suggests that whole aggregated configuration has been
        /// returned as a response to initial API call, as the size of aggregated
        /// configuration is not big enough to need pagination.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        [NSXTProperty(IsRequired: false, Description: @"Paginated aggregated configuration of a given draft.For an initial API call, if request_id is present in response, then this isa paginated aggregated configuration of a given draft. To get more granularaggregated configuration, request_id need to be passed to subsequent APIcalls.Absence of request_id suggests that whole aggregated configuration has beenreturned as a response to initial API call, as the size of aggregatedconfiguration is not big enough to need pagination.")]
        public NSXTInfraType Result { get; set; }
        /// <summary>
        /// Request identifier to keep track of calculated aggregated configuration
        /// a draft during subsequent API calls after initial API call.
        /// This identifier can be use to fetch the detailed aggregated configuration
        /// at security policy level.
        /// Absence of request_id suggests that whole aggregated configuration has been
        /// returned as a response to initial API call, as the size of aggregated
        /// configuration is not big enough to need pagination.
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        [NSXTProperty(IsRequired: false, Description: @"Request identifier to keep track of calculated aggregated configurationa draft during subsequent API calls after initial API call.This identifier can be use to fetch the detailed aggregated configurationat security policy level.Absence of request_id suggests that whole aggregated configuration has beenreturned as a response to initial API call, as the size of aggregatedconfiguration is not big enough to need pagination.")]
        public string? RequestId { get; set; }
    }
}

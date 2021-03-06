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
    /// Paginated result of aggregated configuration of a policy draft
    /// </summary>
    [NSXTProperty(Description: @"Paginated result of aggregated configuration of a policy draft")]
    public class NSXTPolicyDraftPaginatedAggregatedConfigurationResultType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "result")]
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
        public string? RequestId { get; set; }
    }
}

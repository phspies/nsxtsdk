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
    public class NSXTGlobalManagerType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Fail onboarding if maximum RTT exceeded.
        /// </summary>
        [JsonProperty(PropertyName = "fail_if_rtt_exceeded")]
        public bool? FailIfRttExceeded { get; set; }
        /// <summary>
        /// Internally generated UUID to the federation of Global Manager.
        /// </summary>
        [JsonProperty(PropertyName = "federation_id")]
        public string? FederationId { get; set; }
        /// <summary>
        /// There can be at most one ACTIVE global manager and one STANDBY global manager.
        /// In order to add a STANDBY manager, there must be an ACTIVE manager defined.
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGlobalManagerModeEnumType Mode { get; set; }
        /// <summary>
        /// To create a standby GM, the connection information (username, password,
        /// and API thumbprint) for at least one NSX manager node in the remote
        /// site must be provided. Once the GM has been successfully onboarded,
        /// the connection_info is discarded and authentication to the
        /// standby GM occurs using an X.509 client certificate.
        /// </summary>
        [JsonProperty(PropertyName = "connection_info")]
        public IList<NSXTSiteNodeConnectionInfoType> ConnectionInfo { get; set; }
        /// <summary>
        /// If provided and fail_if_rtt_exceeded is true, onboarding of the site will
        /// fail if measured RTT is greater than this value.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_rtt")]
        public long? MaximumRtt { get; set; }
        /// <summary>
        /// UUID of the site where Global manager is running. This is the
        /// Site Manager generated UUID for every NSX deployment.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
    }
}

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
    public class NSXTSiteType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "federation_config")]
        public NSXTGmFederationSiteConfigType FederationConfig { get; set; }
        /// <summary>
        /// Fail onboarding if maximum RTT exceeded.
        /// </summary>
        [JsonProperty(PropertyName = "fail_if_rtt_exceeded")]
        public bool? FailIfRttExceeded { get; set; }
        /// <summary>
        /// 12-bit system generated site number
        /// </summary>
        [JsonProperty(PropertyName = "site_number")]
        public long? SiteNumber { get; set; }
        /// <summary>
        /// If provided and fail_if_rtt_exceeded is true, onboarding of the site will
        /// fail if measured RTT is greater than this value.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_rtt")]
        public long? MaximumRtt { get; set; }
        /// <summary>
        /// Both the local site and the remote site must have edge clusters correctly
        /// configured and remote tunnel endpoint (RTEP) interfaces must be defined,
        /// or onboarding will fail.
        /// </summary>
        [JsonProperty(PropertyName = "fail_if_rtep_misconfigured")]
        public bool? FailIfRtepMisconfigured { get; set; }
        /// <summary>
        /// To onboard a site, the connection information (username, password,
        /// and API thumbprint) for at least one NSX manager node in the remote
        /// site must be provided. Once the site has been successfully onboarded,
        /// the site_connection_info is discarded and authentication to the
        /// remote site occurs using an X.509 client certificate.
        /// </summary>
        [JsonProperty(PropertyName = "site_connection_info")]
        public IList<NSXTSiteNodeConnectionInfoType> SiteConnectionInfo { get; set; }
    }
}

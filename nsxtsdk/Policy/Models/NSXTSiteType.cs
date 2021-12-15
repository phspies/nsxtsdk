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
    public class NSXTSiteType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// System managed federation config.
        /// </summary>
        [JsonProperty(PropertyName = "federation_config")]
        [NSXTProperty(IsRequired: false, Description: @"System managed federation config.")]
        public NSXTGmFederationSiteConfigType FederationConfig { get; set; }
        /// <summary>
        /// Fail onboarding if maximum RTT exceeded.
        /// </summary>
        [JsonProperty(PropertyName = "fail_if_rtt_exceeded")]
        [NSXTProperty(IsRequired: false, Description: @"Fail onboarding if maximum RTT exceeded.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? FailIfRttExceeded { get; set; }
        /// <summary>
        /// 12-bit system generated site number
        /// </summary>
        [JsonProperty(PropertyName = "site_number")]
        [NSXTProperty(IsRequired: false, Description: @"12-bit system generated site number")]
        public long? SiteNumber { get; set; }
        /// <summary>
        /// If provided and fail_if_rtt_exceeded is true, onboarding of the site will
        /// fail if measured RTT is greater than this value.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_rtt")]
        [NSXTProperty(IsRequired: false, Description: @"If provided and fail_if_rtt_exceeded is true, onboarding of the site willfail if measured RTT is greater than this value.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(1000)]
        [NSXTDefaultProperty(Default: "")]
        public long? MaximumRtt { get; set; }
        /// <summary>
        /// Both the local site and the remote site must have edge clusters correctly
        /// configured and remote tunnel endpoint (RTEP) interfaces must be defined,
        /// or onboarding will fail.
        /// </summary>
        [JsonProperty(PropertyName = "fail_if_rtep_misconfigured")]
        [NSXTProperty(IsRequired: false, Description: @"Both the local site and the remote site must have edge clusters correctlyconfigured and remote tunnel endpoint (RTEP) interfaces must be defined,or onboarding will fail.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? FailIfRtepMisconfigured { get; set; }
        /// <summary>
        /// To onboard a site, the connection information (username, password,
        /// and API thumbprint) for at least one NSX manager node in the remote
        /// site must be provided. Once the site has been successfully onboarded,
        /// the site_connection_info is discarded and authentication to the
        /// remote site occurs using an X.509 client certificate.
        /// </summary>
        [JsonProperty(PropertyName = "site_connection_info")]
        [NSXTProperty(IsRequired: false, Description: @"To onboard a site, the connection information (username, password,and API thumbprint) for at least one NSX manager node in the remotesite must be provided. Once the site has been successfully onboarded,the site_connection_info is discarded and authentication to theremote site occurs using an X.509 client certificate.")]
        public IList<NSXTSiteNodeConnectionInfoType> SiteConnectionInfo { get; set; }
    }
}
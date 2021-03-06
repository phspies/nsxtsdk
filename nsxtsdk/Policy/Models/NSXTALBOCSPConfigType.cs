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
    /// Advanced load balancer OCSPConfig object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer OCSPConfig object")]
    public class NSXTALBOCSPConfigType 
    {
        /// <summary>
        /// Describes the type of action to take with the Responder
        /// URLs.
        /// Enum options - OCSP_RESPONDER_URL_FAILOVER,
        /// OCSP_RESPONDER_URL_OVERRIDE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// OCSP_RESPONDER_URL_FAILOVER.
        /// </summary>
        [JsonProperty(PropertyName = "url_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbocspconfigUrlActionEnumType? UrlAction { get; set; }
        /// <summary>
        /// Interval between the OCSP queries.
        /// Allowed values are 60-31536000.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 86400.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_req_interval")]
        public long? OcspReqInterval { get; set; }
        /// <summary>
        /// Time in seconds that the system waits for a reply from the
        /// OCSP responder before dropping the connection.
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_resp_timeout")]
        public long? OcspRespTimeout { get; set; }
        /// <summary>
        /// Maximum number of times the failed OCSP jobs can be
        /// scheduled.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "max_tries")]
        public long? MaxTries { get; set; }
        /// <summary>
        /// Describes the Time Interval after which the next OCSP job
        /// needs to be scheduled in case of the OCSP job failures.
        /// Allowed values are 60-86400.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 3600.
        /// </summary>
        [JsonProperty(PropertyName = "failed_ocsp_jobs_retry_interval")]
        public long? FailedOcspJobsRetryInterval { get; set; }
        /// <summary>
        /// List of Responder URLs configured by user to do
        /// failover/override the AIA extension contained in the OCSP
        /// responder's SSL/TLS certificate.
        /// </summary>
        [JsonProperty(PropertyName = "responder_url_lists")]
        public IList<string> ResponderUrlLists { get; set; }
    }
}

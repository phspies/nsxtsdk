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
    /// Details about an existing NSX manager to be migrated
    /// </summary>
    [NSXTProperty(Description: @"Details about an existing NSX manager to be migrated")]
    public class NSXTSourceNsxApiEndpointType 
    {
        /// <summary>
        /// VC port that will be used to fetch details.
        /// </summary>
        [JsonProperty(PropertyName = "vc_port")]
        public int? VcPort { get; set; }
        /// <summary>
        /// Username for connecting to VC.
        /// </summary>
        [JsonProperty(PropertyName = "vc_username")]
        public string? VcUsername { get; set; }
        /// <summary>
        /// IP address or host name of VC.
        /// </summary>
        [JsonProperty(PropertyName = "vc_ip")]
        public string? VcIp { get; set; }
        /// <summary>
        /// IP address or hostname of a source NSX API endpoint. This field is not applicable in case of vSphere network migration.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// Auth token used to make REST calls to the source NSX API endpoint. This field is not applicable in case of vSphere
        /// network migration. Please generate the token with a sufficiently large duration so that it does not expire in the middle
        /// of the migration. If it does expire, then the token needs to be refreshed manually by invoking this API again with a new
        /// token. Alternatively, you can provide the username/password of the source NSX.
        /// </summary>
        [JsonProperty(PropertyName = "auth_token")]
        public string? AuthToken { get; set; }
        /// <summary>
        /// Signifies Universal Sync role status (STANDALONE, PRIMARY, SECONDARY) of a source NSX API endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_syncrole")]
        public string? NsxSyncrole { get; set; }
        /// <summary>
        /// Build version of VC.
        /// </summary>
        [JsonProperty(PropertyName = "vc_version")]
        public string? VcVersion { get; set; }
        /// <summary>
        /// Username for connecting to NSX manager. This field is not applicable in case of vSphere network migration.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_username")]
        public string? NsxUsername { get; set; }
        /// <summary>
        /// Build version (major, minor, patch) of a source NSX API endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_version")]
        public string? NsxVersion { get; set; }
        /// <summary>
        /// Password for connecting to NSX manager. This field is not applicable in case of vSphere network migration.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_password")]
        public string? NsxPassword { get; set; }
        /// <summary>
        /// Password for connecting to VC.
        /// </summary>
        [JsonProperty(PropertyName = "vc_password")]
        public string? VcPassword { get; set; }
    }
}

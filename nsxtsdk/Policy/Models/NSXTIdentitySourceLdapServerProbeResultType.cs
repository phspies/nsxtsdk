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
    /// The results of probing an individual LDAP server.
    /// </summary>
    [NSXTProperty(Description: @"The results of probing an individual LDAP server.")]
    public class NSXTIdentitySourceLdapServerProbeResultType 
    {
        /// <summary>
        /// THe URL of the probed LDAP host.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Detail about errors encountered during the probe.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<NSXTLdapProbeErrorType> Errors { get; set; }
        /// <summary>
        /// Overall result of the probe. If the probe was able to connect to the LDAP service, authenticate using the provided
        /// credentials, and perform searches of the configured user and group search bases without error, the result is SUCCESS.
        /// Otherwise, the result is FAILURE, and additional details may be found in the errors property.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdentitySourceLdapServerProbeResultResultEnumType? Result { get; set; }
    }
}

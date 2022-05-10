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
    public class NSXTLdapIdentitySourceProbeResultsType : NSXTResourceType
    {
        /// <summary>
        /// Probe results for all probed LDAP servers.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIdentitySourceLdapServerProbeResultType> Results { get; set; }
    }
}

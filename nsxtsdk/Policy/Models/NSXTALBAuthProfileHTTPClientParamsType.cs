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
    /// Advanced load balancer AuthProfileHTTPClientParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthProfileHTTPClientParams object")]
    public class NSXTALBAuthProfileHTTPClientParamsType 
    {
        /// <summary>
        /// The max allowed length of time a clients authentication is
        /// cached.
        /// Allowed values are 1-30.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 5.
        /// </summary>
        [JsonProperty(PropertyName = "cache_expiration_time")]
        public long? CacheExpirationTime { get; set; }
        /// <summary>
        /// A user should be a member of these groups.
        /// Each group is defined by the DN.
        /// For example,
        /// CN=testgroup,OU=groups,dc=example,dc=avinetworks,DC=com.
        /// </summary>
        [JsonProperty(PropertyName = "require_user_groups")]
        public IList<string> RequireUserGroups { get; set; }
        /// <summary>
        /// Insert an HTTP header.
        /// This field is used to define the header name.
        /// The value of the header is set to the client's HTTP Auth
        /// user ID.
        /// </summary>
        [JsonProperty(PropertyName = "request_header")]
        public string? RequestHeader { get; set; }
    }
}

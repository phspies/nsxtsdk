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
    public class NSXTDirectoryEventLogServerType : NSXTManagedResourceType
    {
        /// <summary>
        /// Directory event log server connection user name.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public NSXTDirectoryEventLogServerStatusType Status { get; set; }
        /// <summary>
        /// Directory Event Log server DNS host name or ip address which is reachable by NSX manager to be connected and do event
        /// fetching.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Directory event log server connection password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Directory domain name which best describes the domain. It could be unique fqdn name or it could also be descriptive.
        /// There is no unique contraint for domain name among different domains.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        public string? DomainName { get; set; }
    }
}

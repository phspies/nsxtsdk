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
    /// The credentials to login into the host node
    /// </summary>
    [NSXTProperty(Description: @"The credentials to login into the host node")]
    public class NSXTHostNodeLoginCredentialType 
    {
        /// <summary>
        /// The username of the account on the host node
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// The authentication password of the host node
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// For ESXi hosts, the thumbprint of the ESXi management service.
        /// For KVM hosts, the SSH key fingerprint.
        /// If thumbprint is not provided then connection to host may not
        /// be established and API call will fail.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}

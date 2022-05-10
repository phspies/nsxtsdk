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
    /// Collection of Login/Logout events reported to Policy
    /// </summary>
    [NSXTProperty(Description: @"Collection of Login/Logout events reported to Policy")]
    public class NSXTLoginLogoutEventCollectionType 
    {
        /// <summary>
        /// Set of user to IP address pair
        /// </summary>
        [JsonProperty(PropertyName = "login_logout_events", Required = Required.AllowNull)]
        public IList<NSXTLoginLogoutEventMapType> LoginLogoutEvents { get; set; }
    }
}

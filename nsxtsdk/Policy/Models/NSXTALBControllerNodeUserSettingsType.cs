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
    public class NSXTALBControllerNodeUserSettingsType 
    {
        /// <summary>
        /// Password for the controller node admin user. For deployment,
        /// this property is required.
        /// The password specified must be at least 8 characters in length.
        /// </summary>
        [JsonProperty(PropertyName = "admin_password")]
        public string? AdminPassword { get; set; }
        /// <summary>
        /// To configure ssh into the Advanced Load Balancer controller, this property is required.
        /// </summary>
        [JsonProperty(PropertyName = "admin_ssh_key")]
        public string? AdminSshKey { get; set; }
    }
}

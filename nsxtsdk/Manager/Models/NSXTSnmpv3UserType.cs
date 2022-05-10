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
    /// SNMP v3 user properties
    /// </summary>
    [NSXTProperty(Description: @"SNMP v3 user properties")]
    public class NSXTSnmpV3UserType 
    {
        /// <summary>
        /// SNMP v3 user private password
        /// </summary>
        [JsonProperty(PropertyName = "priv_password")]
        public string? PrivPassword { get; set; }
        /// <summary>
        /// SNMP v3 user auth password
        /// </summary>
        [JsonProperty(PropertyName = "auth_password")]
        public string? AuthPassword { get; set; }
        /// <summary>
        /// SNMP v3 user ID
        /// </summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.AllowNull)]
        public string UserId { get; set; }
    }
}

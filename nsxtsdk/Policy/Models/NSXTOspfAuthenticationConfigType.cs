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
    /// Enables OSPF authentication with specified mode and password.
    /// </summary>
    [NSXTProperty(Description: @"Enables OSPF authentication with specified mode and password.")]
    public class NSXTOspfAuthenticationConfigType 
    {
        /// <summary>
        /// Authentication secret key id is mandatory for type md5 with min value of 1 and max value 255.
        /// </summary>
        [JsonProperty(PropertyName = "key_id")]
        public long? KeyId { get; set; }
        /// <summary>
        /// Authentication secret is mandatory for type password and md5 with min length of 1 and max length 8.
        /// </summary>
        [JsonProperty(PropertyName = "secret_key")]
        public string? SecretKey { get; set; }
        /// <summary>
        /// If mode is MD5 or PASSWORD, Authentication secret key is mandatory
        /// if mode is NONE, then authentication is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTOspfAuthenticationConfigModeEnumType? Mode { get; set; }
    }
}

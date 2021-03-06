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
    /// Advanced load balancer AuthenticationAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthenticationAction object")]
    public class NSXTALBAuthenticationActionType 
    {
        /// <summary>
        /// Authentication Action to be taken for a matched Rule.
        /// Enum options - SKIP_AUTHENTICATION,
        /// USE_DEFAULT_AUTHENTICATION.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as USE_DEFAULT_AUTHENTICATION.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbauthenticationActionTypeEnumType? Type { get; set; }
    }
}

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
    public class NSXTDnsSecurityProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Time to live for DNS cache entry in seconds. Valid TTL values are between 3600
        /// to 864000. However, this field accepts values between 0 through 864000. We define
        /// TTL type based on the value of TTL as follows:
        /// TTL 0 - cached entry never expires.
        /// TTL 1 to 3599 - invalid input and error is thrown
        /// TTL 3600 to 864000 - ttl is set to user input
        /// TTL field not set by user - TTL type is 'AUTO' and ttl value is set from DNS response packet.
        /// 
        /// User defined TTL value is used only when it is betweeen 3600 to 864000.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
    }
}

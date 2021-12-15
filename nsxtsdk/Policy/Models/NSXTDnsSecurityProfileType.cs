// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Time to live for DNS cache entry in seconds. Valid TTL values are between 3600to 864000. However, this field accepts values between 0 through 864000. We defineTTL type based on the value of TTL as follows:TTL 0 - cached entry never expires.TTL 1 to 3599 - invalid input and error is thrownTTL 3600 to 864000 - ttl is set to user inputTTL field not set by user - TTL type is &apos;AUTO&apos; and ttl value is set from DNS response packet.User defined TTL value is used only when it is betweeen 3600 to 864000.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(864000)]
        [NSXTDefaultProperty(Default: "")]
        public long? Ttl { get; set; }
    }
}

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
    public class NSXTL4PolicyLbPersistenceProfileType : NSXTPolicyLbPersistenceProfileType
    {
        /// <summary>
        /// This field indicates the persistence method used for the
        /// PolicyLbVirtualServer.
        /// - SOURCE_IP persistence ensures all connections from a client
        /// (identified by IP address) are sent to the same backend server for a
        /// specified period.
        /// - This object is not required and persistence is disabled by
        /// default
        /// </summary>
        [JsonProperty(PropertyName = "persistence")]
        [NSXTProperty(IsRequired: false, Description: @"This field indicates the persistence method used for thePolicyLbVirtualServer.- SOURCE_IP persistence ensures all connections from a client(identified by IP address) are sent to the same backend server for aspecified period.- This object is not required and persistence is disabled bydefault")]
        [NSXTDefaultProperty(Default: "SOURCE_IP")]
        public NSXTL4PolicyLbPersistenceProfilePersistenceEnumType? Persistence { get; set; }
    }
}

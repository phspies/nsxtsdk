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
    public class NSXTL7PolicyLbPersistenceProfileType : NSXTPolicyLbPersistenceProfileType
    {
        /// <summary>
        /// This field indicates the persistence method used for the
        /// PolicyLbVirtualServer.
        /// - COOKIE persistence allows related client connections, identified by
        /// the same cookie in HTTP requests [Refer to HTTP Cookie for details
        /// on HTTP cookies], to be redirected to the same server. Load
        /// balancer does not maintain any persistence table for cookie
        /// persistence. Instead, it encodes the necessary information in the
        /// HTTP cookie value sent to client and relies on the client to store
        /// it and send it back in subsequent related HTTP requests. Hence
        /// there is no limit on the number of cookie persistence entries that
        /// can be supported.
        /// - This object is not required and persistence is disabled by default
        /// </summary>
        [JsonProperty(PropertyName = "persistence")]
        [NSXTProperty(IsRequired: false, Description: @"This field indicates the persistence method used for thePolicyLbVirtualServer.- COOKIE persistence allows related client connections, identified bythe same cookie in HTTP requests [Refer to HTTP Cookie for detailson HTTP cookies], to be redirected to the same server. Loadbalancer does not maintain any persistence table for cookiepersistence. Instead, it encodes the necessary information in theHTTP cookie value sent to client and relies on the client to storeit and send it back in subsequent related HTTP requests. Hencethere is no limit on the number of cookie persistence entries thatcan be supported.- This object is not required and persistence is disabled by default")]
        [NSXTDefaultProperty(Default: "COOKIE")]
        public NSXTL7PolicyLbPersistenceProfilePersistenceEnumType? Persistence { get; set; }
    }
}
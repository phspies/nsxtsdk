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
    public class NSXTGatewayFloodProtectionProfileType : NSXTFloodProtectionProfileType
    {
        /// <summary>
        /// The maximum limit of active NAT connections. This limit only apply to EDGE components (such as, gateway). If this
        /// property is omitted, or set to null, then there is no limit on the specific component. Meanwhile there is an implicit
        /// limit which depends on the underlying hardware resource.
        /// </summary>
        [JsonProperty(PropertyName = "nat_active_conn_limit")]
        [NSXTProperty(IsRequired: false, Description: @"The maximum limit of active NAT connections. This limit only apply to EDGE components (such as, gateway). If this property is omitted, or set to null, then there is no limit on the specific component. Meanwhile there is an implicit limit which depends on the underlying hardware resource.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        [NSXTDefaultProperty(Default: "")]
        public long? NatActiveConnLimit { get; set; }
    }
}

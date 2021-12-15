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
    /// DHCP option 121 to define classless static route.
    /// </summary>
    [NSXTProperty(Description: @"DHCP option 121 to define classless static route.")]
    public class NSXTDhcpOption121Type 
    {
        /// <summary>
        /// Classless static route of DHCP option 121.
        /// </summary>
        [JsonProperty(PropertyName = "static_routes", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Classless static route of DHCP option 121.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTClasslessStaticRouteType> StaticRoutes { get; set; }
    }
}
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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpStaticBindingListResultType : NSXTListResultType
    {
        public NSXTDhcpStaticBindingListResultType()
        {
        }
        /// <summary>
        /// A paginated list of DHCP static bindings.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A paginated list of DHCP static bindings.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTDhcpStaticBindingType> Results { get; set; }
    }
}

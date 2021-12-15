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
    /// Define DHCP options other than option 121.
    /// </summary>
    [NSXTProperty(Description: @"Define DHCP options other than option 121.")]
    public class NSXTGenericDhcpOptionType 
    {
        /// <summary>
        /// Code of the dhcp option.
        /// </summary>
        [JsonProperty(PropertyName = "code", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Code of the dhcp option.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(255)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Code { get; set; }
        /// <summary>
        /// Value of the option.
        /// </summary>
        [JsonProperty(PropertyName = "values", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of the option.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Values { get; set; }
    }
}

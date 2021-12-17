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
    public class NSXTMACAddressExpressionType : NSXTExpressionType
    {
        public NSXTMACAddressExpressionType()
        {
        }
        /// <summary>
        /// This array can consist of one or more MAC addresses.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addresses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This array can consist of one or more MAC addresses.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> MacAddresses { get; set; }
    }
}

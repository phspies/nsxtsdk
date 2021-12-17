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
    public class NSXTServiceReferenceType : NSXTPolicyConfigResourceType
    {
        public NSXTServiceReferenceType()
        {
            Enabled = test
        }
        /// <summary>
        /// Unique name of Partner Service to be consumed for redirection.
        /// </summary>
        [JsonProperty(PropertyName = "partner_service_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Unique name of Partner Service to be consumed for redirection.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PartnerServiceName { get; set; }
        /// <summary>
        /// A Service's operational state can be enabled or disabled. Note that would work only for NetX type of services and would
        /// not work for Guest Introsp- ection type of Services. TRUE - The Service should be enabled FALSE - The Service should be
        /// disabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"A Service&apos;s operational state can be enabled or disabled. Note that would work only for NetX type of services and would not work for Guest Introsp- ection type of Services. TRUE - The Service should be enabled FALSE - The Service should be disabled")]
        public bool? Enabled { get; set; }
    }
}

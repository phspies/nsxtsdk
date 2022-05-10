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
    public class NSXTServiceReferenceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Unique name of Partner Service to be consumed for redirection.
        /// </summary>
        [JsonProperty(PropertyName = "partner_service_name", Required = Required.AllowNull)]
        public string PartnerServiceName { get; set; }
        /// <summary>
        /// A Service's operational state can be enabled or disabled. Note that would work only for NetX type of services and would
        /// not work for Guest Introsp- ection type of Services. TRUE - The Service should be enabled FALSE - The Service should be
        /// disabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}

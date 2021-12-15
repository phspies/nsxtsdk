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
    public class NSXTTier0AdvancedConfigType : NSXTConnectivityAdvancedConfigType
    {
        /// <summary>
        /// Extra time in seconds the router must wait before sending the UP
        /// notification after the peer routing session is established. Default
        /// means forward immediately. VRF logical router will set it same as parent
        /// logical router.
        /// </summary>
        [JsonProperty(PropertyName = "forwarding_up_timer")]
        [NSXTProperty(IsRequired: false, Description: @"Extra time in seconds the router must wait before sending the UPnotification after the peer routing session is established. Defaultmeans forward immediately. VRF logical router will set it same as parentlogical router.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(300)]
        [NSXTDefaultProperty(Default: "")]
        public long? ForwardingUpTimer { get; set; }
    }
}

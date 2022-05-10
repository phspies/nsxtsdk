using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTQosSwitchingProfileType : NSXTBaseSwitchingProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "shaper_configuration")]
        public IList<NSXTQosBaseRateShaperType> ShaperConfiguration { get; set; }
        /// <summary>
        /// Class of service
        /// </summary>
        [JsonProperty(PropertyName = "class_of_service")]
        public int? ClassOfService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dscp")]
        public NSXTDscpType Dscp { get; set; }
    }
}

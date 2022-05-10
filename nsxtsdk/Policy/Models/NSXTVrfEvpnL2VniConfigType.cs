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
    public class NSXTVrfEvpnL2VniConfigType 
    {
        /// <summary>
        /// Define L2 VNI and its related route distinguiser and route targets.
        /// </summary>
        [JsonProperty(PropertyName = "l2_vni_configs", Required = Required.AllowNull)]
        public IList<NSXTVrfL2VniConfigType> L2VniConfigs { get; set; }
        /// <summary>
        /// This is used to enable or disable the creation of vtep groups. Each vtep group
        /// is used to group vteps with the same MAC for L2 ECMP usage.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vtep_groups")]
        public bool? EnableVtepGroups { get; set; }
    }
}

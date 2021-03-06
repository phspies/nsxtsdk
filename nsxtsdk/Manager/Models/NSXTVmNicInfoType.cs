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
    /// Contains a set of information of a VM on the network interfaces present on the partner appliance that needs to be
        /// configured by the NSX Manager.
    /// </summary>
    [NSXTProperty(Description: @"Contains a set of information of a VM on the network interfaces present on the partner appliance that needs to be configured by the NSX Manager.")]
    public class NSXTVmNicInfoType 
    {
        /// <summary>
        /// Set of information of a VM on the network interfaces present on the partner appliance that needs to be configured by the
        /// NSX Manager.
        /// </summary>
        [JsonProperty(PropertyName = "nic_infos", Required = Required.AllowNull)]
        public IList<NSXTNicInfoType> NicInfos { get; set; }
    }
}

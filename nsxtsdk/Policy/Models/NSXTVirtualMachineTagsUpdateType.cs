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
    /// List of tags applied to the virtual machine. Based on the enforcement
        /// point, the virtual_machine_id will be different. It could be an external
        /// id for NSX T or a moid for NSX V
    /// </summary>
    [NSXTProperty(Description: @"List of tags applied to the virtual machine. Based on the enforcementpoint, the virtual_machine_id will be different. It could be an externalid for NSX T or a moid for NSX V")]
    public class NSXTVirtualMachineTagsUpdateType 
    {
        /// <summary>
        /// The identifier that is used in the enforcement point that uniquely
        /// identifies the virtual machine. In case of NSXT it would be the
        /// value of the external_id of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machine_id", Required = Required.AllowNull)]
        public string VirtualMachineId { get; set; }
        /// <summary>
        /// List of tags to be applied on the virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "tags", Required = Required.AllowNull)]
        public IList<NSXTTagType> Tags { get; set; }
    }
}

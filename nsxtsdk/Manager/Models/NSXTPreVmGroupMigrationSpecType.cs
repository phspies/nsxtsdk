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
    /// Migration spec for a VM group that will be used in pre VM group migration step.
    /// </summary>
    [NSXTProperty(Description: @"Migration spec for a VM group that will be used in pre VM group migration step.")]
    public class NSXTPreVmGroupMigrationSpecType 
    {
        /// <summary>
        /// Flag to indicate whether to re-run the pre migrate steps for the VM group if they are already run before.
        /// </summary>
        [JsonProperty(PropertyName = "allow_override")]
        public bool? AllowOverride { get; set; }
        /// <summary>
        /// User defined VM group id that must be unique among all VM groups ids.
        /// </summary>
        [JsonProperty(PropertyName = "group_id", Required = Required.AllowNull)]
        public string GroupId { get; set; }
        /// <summary>
        /// List of VM instance uuids that can be found in VC inventory.
        /// </summary>
        [JsonProperty(PropertyName = "vm_instance_ids", Required = Required.AllowNull)]
        public IList<string> VmInstanceIds { get; set; }
    }
}

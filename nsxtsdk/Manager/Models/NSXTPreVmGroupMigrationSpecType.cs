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
    /// Migration spec for a VM group that will be used in pre VM group migration step.
    /// </summary>
    [NSXTProperty(Description: @"Migration spec for a VM group that will be used in pre VM group migration step.")]
    public class NSXTPreVmGroupMigrationSpecType 
    {
        public NSXTPreVmGroupMigrationSpecType()
        {
        }
        /// <summary>
        /// Flag to indicate whether to re-run the pre migrate steps for the VM group if they are already run before.
        /// </summary>
        [JsonProperty(PropertyName = "allow_override")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to indicate whether to re-run the pre migrate steps for the VM group if they are already run before.")]
        public bool? AllowOverride { get; set; }
        /// <summary>
        /// User defined VM group id that must be unique among all VM groups ids.
        /// </summary>
        [JsonProperty(PropertyName = "group_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"User defined VM group id that must be unique among all VM groups ids.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GroupId { get; set; }
        /// <summary>
        /// List of VM instance uuids that can be found in VC inventory.
        /// </summary>
        [JsonProperty(PropertyName = "vm_instance_ids", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of VM instance uuids that can be found in VC inventory.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> VmInstanceIds { get; set; }
    }
}

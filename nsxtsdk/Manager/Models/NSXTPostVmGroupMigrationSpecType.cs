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
    /// Migration spec for a VM group that will be used in post VM group migration step.
    /// </summary>
    [NSXTProperty(Description: @"Migration spec for a VM group that will be used in post VM group migration step.")]
    public class NSXTPostVmGroupMigrationSpecType 
    {
        /// <summary>
        /// Flag to indicate whether to re-run the post migrate steps for the VM group if they are already run before.
        /// </summary>
        [JsonProperty(PropertyName = "allow_override")]
        public bool? AllowOverride { get; set; }
        /// <summary>
        /// User defined VM group id that must be unique among all VM groups ids and also should match the group id used in the pre
        /// VM group migrate API.
        /// </summary>
        [JsonProperty(PropertyName = "group_id", Required = Required.AllowNull)]
        public string GroupId { get; set; }
        /// <summary>
        /// List of instance uuids of VMs that failed to migrate.
        /// </summary>
        [JsonProperty(PropertyName = "failed_vm_instance_ids")]
        public IList<string> FailedVmInstanceIds { get; set; }
    }
}

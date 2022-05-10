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
    /// VIF attachment state of a logical port
    /// </summary>
    [NSXTProperty(Description: @"VIF attachment state of a logical port")]
    public class NSXTLogicalPortAttachmentStateType 
    {
        /// <summary>
        /// A logicalPort must be in one of following state.
        /// FREE - If there are no active attachers. The LogicalPort may or
        /// may not have an attachment ID configured on it. This state is
        /// applicable only to LogialPort of static type.
        /// ATTACHED - LogicalPort has exactly one active attacher and no
        /// further configuration is pending.
        /// ATTACHED_PENDING_CONF - LogicalPort has exactly one attacher,
        /// however it may not have been configured completely. Additional
        /// configuration will be provided by other nsx components.
        /// ATTACHED_IN_MOTION - LogicalPort has multiple active attachers.
        /// This state represents a scenario where VM is moving from one
        /// location (host or storage) to another (e.g. vmotion, vSphere HA)
        /// DETACHED - A temporary state after all LogialPort attachers have
        /// been detached. This state is applicable only to LogicalPort of
        /// ephemeral type and the LogicalPort will soon be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalPortAttachmentStateStateEnumType? State { get; set; }
        /// <summary>
        /// VM or vmknic entities that are attached to the LogicalPort
        /// </summary>
        [JsonProperty(PropertyName = "attachers")]
        public IList<NSXTPortAttacherType> Attachers { get; set; }
        /// <summary>
        /// VIF ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}

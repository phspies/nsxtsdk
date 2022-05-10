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
    public class NSXTALBAutoScaleLaunchConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Unique ID of the Amazon Machine Image (AMI)  or OpenStack
        /// VM ID.
        /// </summary>
        [JsonProperty(PropertyName = "image_id")]
        public string? ImageId { get; set; }
        /// <summary>
        /// If set to True, ServerAutoscalePolicy will use the
        /// autoscaling group (external_autoscaling_groups) from Pool to
        /// perform scale up and scale down.
        /// Pool should have single autoscaling group configured.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "use_external_asg")]
        public bool? UseExternalAsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mesos")]
        public NSXTALBAutoScaleMesosSettingsType Mesos { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "openstack")]
        public NSXTALBAutoScaleOpenStackSettingsType Openstack { get; set; }
    }
}

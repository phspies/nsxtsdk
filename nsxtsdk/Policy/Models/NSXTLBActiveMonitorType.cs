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
    public class NSXTLBActiveMonitorType : NSXTLBMonitorProfileType
    {
        public NSXTLBActiveMonitorType()
        {
            FallCount = test
            Interval = test
            RiseCount = test
            Timeout = test
        }
        /// <summary>
        /// Typically, monitors perform healthchecks to Group members using the
        /// member IP address and pool_port.
        /// However, in some cases, customers prefer to run healthchecks against a
        /// different port than the pool member port which handles actual
        /// application traffic. In such cases, the port to run healthchecks
        /// against can be specified in the monitor_port value.
        /// For ICMP monitor, monitor_port is not required.
        /// </summary>
        [JsonProperty(PropertyName = "monitor_port")]
        [NSXTProperty(IsRequired: false, Description: @"Typically, monitors perform healthchecks to Group members using themember IP address and pool_port.However, in some cases, customers prefer to run healthchecks against adifferent port than the pool member port which handles actualapplication traffic. In such cases, the port to run healthchecksagainst can be specified in the monitor_port value.For ICMP monitor, monitor_port is not required.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public int? MonitorPort { get; set; }
        /// <summary>
        /// Only if a healthcheck fails consecutively for a specified number of
        /// times, given with fall_count, to a member will the member status be
        /// marked DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "fall_count")]
        [NSXTProperty(IsRequired: false, Description: @"Only if a healthcheck fails consecutively for a specified number oftimes, given with fall_count, to a member will the member status bemarked DOWN.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        public long? FallCount { get; set; }
        /// <summary>
        /// Active healthchecks are initiated periodically, at a configurable
        /// interval (in seconds), to each member of the Group.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        [NSXTProperty(IsRequired: false, Description: @"Active healthchecks are initiated periodically, at a configurableinterval (in seconds), to each member of the Group.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        public long? Interval { get; set; }
        /// <summary>
        /// Once a member is DOWN, a specified number of consecutive successful
        /// healthchecks specified by rise_count will bring the member back to UP
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "rise_count")]
        [NSXTProperty(IsRequired: false, Description: @"Once a member is DOWN, a specified number of consecutive successfulhealthchecks specified by rise_count will bring the member back to UPstate.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        public long? RiseCount { get; set; }
        /// <summary>
        /// Timeout specified in seconds.  After a healthcheck is initiated, if it
        /// does not complete within a certain period, then also the healthcheck
        /// is considered to be unsuccessful. Completing a healthcheck within
        /// timeout means establishing a connection (TCP or SSL), if applicable,
        /// sending the request and receiving the response, all within the
        /// configured timeout.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        [NSXTProperty(IsRequired: false, Description: @"Timeout specified in seconds.  After a healthcheck is initiated, if itdoes not complete within a certain period, then also the healthcheckis considered to be unsuccessful. Completing a healthcheck withintimeout means establishing a connection (TCP or SSL), if applicable,sending the request and receiving the response, all within theconfigured timeout.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        public long? Timeout { get; set; }
    }
}

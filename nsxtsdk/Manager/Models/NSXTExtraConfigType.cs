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
    /// Extra config is intended for supporting vendor specific configuration on the
        /// data path, it can be set as key value string pairs on either logical switch
        /// or logical port.
        /// If it was set on logical switch, it will be inherited automatically by logical
        /// ports in it. Also logical port setting will override logical switch setting
        /// if specific key was dual set on both logical switch and logical port.
    /// </summary>
    [NSXTProperty(Description: @"Extra config is intended for supporting vendor specific configuration on thedata path, it can be set as key value string pairs on either logical switchor logical port.If it was set on logical switch, it will be inherited automatically by logicalports in it. Also logical port setting will override logical switch settingif specific key was dual set on both logical switch and logical port.")]
    public class NSXTExtraConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "config_pair", Required = Required.AllowNull)]
        public NSXTUnboundedKeyValuePairType ConfigPair { get; set; }
    }
}

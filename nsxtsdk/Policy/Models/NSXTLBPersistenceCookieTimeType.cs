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
    public class NSXTLBPersistenceCookieTimeType : NSXTLBCookieTimeType
    {
        /// <summary>
        /// HTTP cookie max-age to expire cookie, only available for insert mode.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_max_idle", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"HTTP cookie max-age to expire cookie, only available for insert mode.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        [System.ComponentModel.DataAnnotations.Required]
        public long CookieMaxIdle { get; set; }
    }
}

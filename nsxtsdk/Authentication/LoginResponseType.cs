using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsxtsdk.Authentication
{
    public class LoginResponseType
    {
        [JsonProperty("roles")]
        public List<RoleType> Roles { get; set; }
    }
    public class RoleType
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }
    }


}

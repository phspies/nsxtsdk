using Newtonsoft.Json;
namespace nsxtsdk.Modules
{
    public class LoginRequestType
    {
        public LoginRequestType(string Username, string Password)
        {
            this.j_username = Username;
            this.j_password = Password;
        }
        [JsonProperty("j_username")]
        public string j_username { get; set; }
        [JsonProperty("j_password")]
        public string j_password { get; set; }
    }
}

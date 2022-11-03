using Newtonsoft.Json;

namespace ServiceAccessBL
{
    public class User
    {
        [JsonProperty("Id")]
        public int UserId;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("isGlobalUser")]
        public bool IsGlobalUser;
    }
}
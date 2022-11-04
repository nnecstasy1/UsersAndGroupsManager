using Newtonsoft.Json;

namespace API
{
    public class ClientGroupUserFB
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("clientGroupId")]
        public int ClientGroupId { get; set; }
    }
}

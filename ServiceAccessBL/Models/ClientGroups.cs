namespace ServiceAccessBL
{
    public class ClientGroups
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("clientGroupId")]
        public int ClientGroupId { get; set; }
    }
}
